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
    public partial class profileForm : Form
    {
        private string tempString = "";
        public profileForm(DataTable userInfo)
        {
            InitializeComponent();
            Innit(userInfo);
        }

        private void Innit(DataTable userInfo)
        {
            this.Text = LogInModule.GetString("changeProfile");
            editProfileLabel.Text = LogInModule.GetString("editProfileLabel");
            usernameLabel.Text = LogInModule.GetString("usernameLabel");
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

            l1.Click += new EventHandler(ChangeToEn);
            l2.Click += new EventHandler(ChangeToEn);
            p1.Click += new EventHandler(ChangeToPl);
            p2.Click += new EventHandler(ChangeToPl);
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

        private void ChangeToEn(object sender, EventArgs e) { LogInModule.ChangeLanguage("en"); Console.WriteLine("Changed to EN"); }
        private void ChangeToPl(object sender, EventArgs e) { LogInModule.ChangeLanguage("pl"); Console.WriteLine("Changed to PL"); }
    }
}
