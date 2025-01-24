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

namespace NStudio.Desktop.Query
{
    public partial class artistInfo : Form
    {
        public DatabaseControl dbControl;
        private DataTable data;
        private string tempString = "";
        private bool avatarChanged;
        private bool isEdited;
        private bool isImageNull;
        public artistInfo(DatabaseControl dbControl, bool isEdited)
        {
            this.dbControl = dbControl;
            this.isEdited = isEdited;
            avatarChanged = false;
            InitializeComponent();
            imageBox.SizeMode = PictureBoxSizeMode.Zoom;
            nameLabel.Text = LogInModule.GetString("nameLabel");
            nicknameLabel.Text = LogInModule.GetString("nicknameLabel");
            labelLabel.Text = LogInModule.GetString("labelLabel");
            changeImageButton.Text = LogInModule.GetString("changeImageButton");
            acceptButton.Text = LogInModule.GetString("acceptButton");
            rejectButton.Text = LogInModule.GetString("rejectButton");
            if (isEdited)
            {
                artistPanelLabel.Text = LogInModule.GetString("artistPanelEditLabel");
            }
            else
            {
                artistPanelLabel.Text = LogInModule.GetString("artistPanelAddLabel");
            }

            List<TextBox> list = new List<TextBox> { nameBox, nicknameBox, labelBox };
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
            nameBox.Text = $"{data.Rows[0][1]}";
            nicknameBox.Text = $"{data.Rows[0][2]}";
            labelBox.Text = $"{data.Rows[0][3]}";
            Image image = null;
            byte[] bytes = (byte[])data.Rows[0][4];
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
                newData.Rows[0][1] = nameBox.Text;
                newData.Rows[0][2] = nicknameBox.Text;
                newData.Rows[0][3] = labelBox.Text;
                if (avatarChanged)
                {
                    byte[] imageArray = dbControl.AvatarToByteArray(imageBox);
                    newData.Rows[0][4] = imageArray;
                }
                else { newData.Rows[0][4] = data.Rows[0][4]; }
                if (isImageNull && !avatarChanged)
                {
                    newData.Rows[0][4] = null;
                    data.Rows[0][4] = null;
                }

                if (!dbControl.CompareTwoDataTable(data, newData))
                {
                    var result = MessageBox.Show(LogInModule.GetString("msgBox1Profile"),
                                              "artistInfo",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        if (dbControl.ChangeRow(newData, (int)newData.Rows[0][0], table: "artists"))
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
                newRow[1] = nameBox.Text;
                newRow[2] = nicknameBox.Text;
                newRow[3] = labelBox.Text;
                if (avatarChanged)
                {
                    byte[] imageArrayP = dbControl.AvatarToByteArray(imageBox);
                    newRow[4] = imageArrayP;
                }
                else { newRow[4] = null; }

                var result = MessageBox.Show(LogInModule.GetString("msgBox1Profile"),
                                              "artistInfo",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    data.Rows.Add(newRow);
                    if (dbControl.AddRowToDB(data, table: "artists"))
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
