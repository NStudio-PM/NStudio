using NStudio.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NStudio.Desktop
{
    public partial class songInfo : Form
    {
        public DatabaseControl dbControl;
        private DataTable data;
        private string tempString = "";
        private bool avatarChanged;
        private bool isEdited;
        private bool isImageNull;

        public songInfo(DatabaseControl dbControl, bool isEdited)
        {
            this.dbControl = dbControl;
            this.isEdited = isEdited;
            avatarChanged = false;
            InitializeComponent();
            imageBox.SizeMode = PictureBoxSizeMode.Zoom;
            titleLabel.Text = LogInModule.GetString("titleLabel");
            authorLabel.Text = LogInModule.GetString("authorLabel");
            recordLabel.Text = LogInModule.GetString("recordLabel");
            yearLabel.Text = LogInModule.GetString("yearLabel");
            costLabel.Text = LogInModule.GetString("costLabel");
            changeImageButton.Text = LogInModule.GetString("changeImageButton");
            acceptButton.Text = LogInModule.GetString("acceptButton");
            rejectButton.Text = LogInModule.GetString("rejectButton");
            if (isEdited)
            {
                songPanelLabel.Text = LogInModule.GetString("songPanelEditLabel");
            }
            else
            {
                songPanelLabel.Text = LogInModule.GetString("songPanelAddLabel");
            }

            List<TextBox> list = new List<TextBox> { titleBox, authorBox, recordBox, yearBox, costBox };
            foreach (TextBox txt in list) { txt.Enter += TextBox_Enter; txt.Leave += TextBox_Leave; }
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            tempString = textBox.Text;
            textBox.Clear();
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "") { textBox.Text = tempString; }
        }

        private void changeAvatarButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.png;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
                    if (fileInfo.Length > 64 * 1024)
                    {
                        MessageBox.Show(LogInModule.GetString("msgBox4Profile"));
                        return;
                    }

                    Image selectedImage = Image.FromFile(openFileDialog.FileName);
                    imageBox.Image = selectedImage;
                    avatarChanged = true;
                }
            }
        }

        public void SetData(DataTable data, bool isImageNull)
        {
            this.data = data;
            this.isImageNull = isImageNull;
            titleBox.Text = $"{data.Rows[0][1]}";
            authorBox.Text = $"{data.Rows[0][2]}";
            recordBox.Text = $"{data.Rows[0][3]}";
            yearBox.Text = $"{(int)data.Rows[0][4]}";
            costBox.Text = $"{(int)data.Rows[0][5] / 100.0f:F2}";
            Image image = null;
            byte[] bytes = (byte[])data.Rows[0][6];
            if (bytes != null && bytes.Length > 0)
            {
                using (var ms = new MemoryStream(bytes))
                {
                    image = Image.FromStream(ms);
                }
            }
            imageBox.Image = image;
            
        }

        public void SetData(DataTable data) 
        {
            this.data = data;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            if (isEdited)
            {
                DataTable newData = data.Clone();
                newData.PrimaryKey = new DataColumn[] { newData.Columns["id"] };
                foreach (DataRow row in data.Rows) { newData.ImportRow(row); }
                newData.Rows[0][1] = titleBox.Text;
                newData.Rows[0][2] = authorBox.Text;
                newData.Rows[0][3] = recordBox.Text;
                newData.Rows[0][4] = yearBox.Text;

                try
                {
                    newData.Rows[0][5] = (int)(decimal.Parse(costBox.Text.Trim(), System.Globalization.CultureInfo.InvariantCulture) * 100);
                }
                catch (FormatException)
                {
                    MessageBox.Show(LogInModule.GetString("msgBoxFormatException"));
                    tempString = "";
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(LogInModule.GetString("msgBoxFormatException") + ": " + ex, LogInModule.GetString("msgBoxError"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tempString = "";
                    this.Close();
                }

                if (avatarChanged)
                {
                    byte[] imageArray = dbControl.AvatarToByteArray(imageBox);
                    newData.Rows[0][6] = imageArray;
                }
                else { newData.Rows[0][6] = data.Rows[0][6]; }
                if (isImageNull && !avatarChanged)
                {
                    newData.Rows[0][6] = null;
                    data.Rows[0][6] = null;
                }

                if(!dbControl.CompareTwoDataTable(data, newData))
                {
                    var result = MessageBox.Show(LogInModule.GetString("msgBox1Profile"),
                                              "songInfo",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        if (dbControl.ChangeRow(newData, (int)newData.Rows[0][0], table: "songs"))
                        {
                            MessageBox.Show(LogInModule.GetString("msgBox2Profile"));
                        }
                        else { MessageBox.Show(LogInModule.GetString("msgBox5Profile")); }
                    }
                    else { MessageBox.Show(LogInModule.GetString("msgBox3Profile")); }
                    tempString = "";
                    this.Close();
                }
            }
            else
            {
                DataRow newRow = data.NewRow();
                newRow[0] = DBNull.Value;
                newRow[1] = titleBox.Text;
                newRow[2] = authorBox.Text;
                newRow[3] = recordBox.Text;
                newRow[4] = yearBox.Text;

                try
                {
                    newRow[5] = (int)(decimal.Parse(costBox.Text.Trim(), System.Globalization.CultureInfo.InvariantCulture) * 100);
                }
                catch (FormatException)
                {
                    MessageBox.Show(LogInModule.GetString("msgBoxFormatException"));
                    tempString = "";
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(LogInModule.GetString("msgBoxFormatException") + ": " + ex, LogInModule.GetString("msgBoxError"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tempString = "";
                    this.Close();
                }

                if (avatarChanged)
                {
                    byte[] imageArrayP = dbControl.AvatarToByteArray(imageBox);
                    newRow[6] = imageArrayP;
                }
                else { newRow[6] = null; }

                var result = MessageBox.Show(LogInModule.GetString("msgBox1Profile"),
                                              "songInfo",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    data.Rows.Add(newRow);
                    if (dbControl.AddRowToDB(data, table: "songs"))
                    {
                        MessageBox.Show(LogInModule.GetString("msgBox2Profile"));
                    }
                    else { MessageBox.Show(LogInModule.GetString("msgBox5Profile")); }
                }
                else { MessageBox.Show(LogInModule.GetString("msgBox3Profile")); }
                tempString = "";
                this.Close();
            }
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            tempString = "";
            this.Close();
        }
    }
}
