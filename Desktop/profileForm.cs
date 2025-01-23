using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NStudio.Desktop
{
    public partial class profileForm : Form
    {
        private string tempString = "";
        private byte[] imageData = null;
        private bool avatarChanged;
        private bool avatarNull;
        public DatabaseControl dbControlProfile;
        public DataTable userInfo;
        public profileForm(DatabaseControl dbControl)
        {
            this.dbControlProfile = dbControl;
            userInfo = dbControlProfile.userInfo;
            avatarChanged = false;
            avatarNull = true;
            InitializeComponent();
            Innit();
            changePasswordButton.Focus();
        }

        private void Innit()
        {
            this.Text = LogInModule.GetString("changeProfile");
            editProfileLabel.Text = LogInModule.GetString("editProfileLabel");
            usernameLabel.Text = LogInModule.GetString("usernameLabel");
            changePasswordLabel.Text = LogInModule.GetString("changePasswordLabel");
            countryLabel.Text = LogInModule.GetString("countryLabel");
            cityLabel.Text = LogInModule.GetString("cityLabel");
            postcodeLabel.Text = LogInModule.GetString("postcodeLabel");
            streetLabel.Text = LogInModule.GetString("streetLabel");
            changeAvatarButton.Text = LogInModule.GetString("changeAvatarButton");
            acceptButton.Text = LogInModule.GetString("acceptButton");
            rejectButton.Text = LogInModule.GetString("rejectButton");

            usernameBox.Text = userInfo.Rows[0][1].ToString();
            countryBox.Text = userInfo.Rows[0][3].ToString();
            postcodeBox.Text = userInfo.Rows[0][4].ToString();
            cityBox.Text = userInfo.Rows[0][5].ToString();
            streetBox.Text = userInfo.Rows[0][6].ToString();
            if(userInfo.Rows[0][8] != DBNull.Value)
            {
                byte[] avatar = (byte[])userInfo.Rows[0][8];
                using (MemoryStream ms = new MemoryStream(avatar))
                {
                    Bitmap bitmap = new Bitmap(ms);
                    avatarBox.Image = bitmap;
                }
            }
            else
            {
                avatarBox.Image = Properties.Resources.defaultAvatar;
            }
            avatarBox.SizeMode = PictureBoxSizeMode.Zoom;

            List<TextBox> list = new List<TextBox> { usernameBox, countryBox, cityBox, postcodeBox, streetBox };
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

        private bool CompareTwoDataTable(DataTable originalUserInfo, DataTable newUserInfo)
        {
            for (int i = 0; i < originalUserInfo.Columns.Count; i++) 
            {
                if(i == 8) 
                {
                    if(originalUserInfo.Rows[0][i] is byte[] byteArray1 && newUserInfo.Rows[0][i] is byte[] byteArray2)
                    if (!CompareTwoByteTable(byteArray1, byteArray2)) { return false; }
                }else 
                {
                    if (originalUserInfo.Rows[0][i].ToString() != newUserInfo.Rows[0][i].ToString()) { return false; }
                }
            }
            return true;
        }

        private bool CompareTwoByteTable(byte[] byteArray1,  byte[] byteArray2)
        {
            if (byteArray1.Length != byteArray2.Length) { return false; }
            for (int i = 0; i < byteArray1.Length; i++)
            {
                if(byteArray1[i] != byteArray2[i]) { 
                    return false; }
            }
            return true;
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            tempString = "";
            this.Close();
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
                    avatarBox.Image = selectedImage;
                    imageData = File.ReadAllBytes(openFileDialog.FileName);
                    avatarChanged = true;
                }
            }
        }

        private byte[] AvatarToByteArray(PictureBox pictureBox)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                pictureBox.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                return memoryStream.ToArray();
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            DataTable newUserInfo = dbControlProfile.userInfo.Clone();
            foreach(DataRow row in dbControlProfile.userInfo.Rows) { newUserInfo.ImportRow(row); }
            if(usernameBox.Text != dbControlProfile.userInfo.Rows[0][1].ToString())
            {
                if (dbControlProfile.UserExists(usernameBox.Text))
                {
                    newUserInfo.Rows[0][1] = dbControlProfile.userInfo.Rows[0][1].ToString();
                    MessageBox.Show(LogInModule.GetString("msgBox6Profile"));
                }
                else
                {
                    newUserInfo.Rows[0][1] = usernameBox.Text;
                }
            }

            newUserInfo.Rows[0][3] = countryBox.Text;
            newUserInfo.Rows[0][4] = postcodeBox.Text;
            newUserInfo.Rows[0][5] = cityBox.Text;
            newUserInfo.Rows[0][6] = streetBox.Text;
            if (avatarChanged)
            {
                byte[] avatarArrayP = AvatarToByteArray(avatarBox);
                newUserInfo.Rows[0][8] = avatarArrayP;
            }
            else { newUserInfo.Rows[0][8] = dbControlProfile.userInfo.Rows[0][8]; }
            if (newUserInfo.Rows[0][8] is byte[] avatarArray) { newUserInfo.Rows[0][8] = avatarArray; }
            else { newUserInfo.Rows[0][8] = null; }

            if(!CompareTwoDataTable(dbControlProfile.userInfo, newUserInfo))
            {
                var result = MessageBox.Show(LogInModule.GetString("msgBox1Profile"),
                                              "UserInfo",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Information);
                if(result == DialogResult.Yes)
                {
                    if (dbControlProfile.ChangeUserInfo(newUserInfo)) {
                        dbControlProfile.userInfo = newUserInfo;
                        MessageBox.Show(LogInModule.GetString("msgBox2Profile")); 
                    } 
                    else { MessageBox.Show(LogInModule.GetString("msgBox5Profile")); }
                }
                else { MessageBox.Show(LogInModule.GetString("msgBox3Profile")); }
                tempString = "";
                this.Close();
            }
            else 
            {
                tempString = ""; 
                this.Close(); 

            }
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            passwordForm passwordForm = new passwordForm(dbControlProfile);
            passwordForm.ShowDialog();
        }
    }
}
