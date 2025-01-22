using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NStudio.Desktop
{
    public partial class passwordForm : Form
    {
        DatabaseControl dbControlPassword;
        public passwordForm(DatabaseControl dbControl)
        {
            InitializeComponent();
            this.dbControlPassword = dbControl;
            this.Text = LogInModule.GetString("passwordFormTitle");
            oldPasswordLabel.Text = LogInModule.GetString("oldPasswordLabel");
            newPasswordLabel.Text = LogInModule.GetString("newPasswordLabel");
            rNewPasswordLabel.Text = LogInModule.GetString("rNewPasswordLabel");
            acceptButton.Text = LogInModule.GetString("acceptButton");
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (newPassword.Text == rNewPassword.Text)
            {
                if(dbControlPassword.ChangePassword(oldPassword.Text, newPassword.Text))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("To jest treść alertu.", "Tytuł okna", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}
