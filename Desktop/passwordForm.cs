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
            if (newPassword.Text == rNewPassword.Text && newPassword.TextLength >= 8)
            {
                if(dbControlPassword.ChangePassword(oldPassword.Text, newPassword.Text))
                {
                    MessageBox.Show(LogInModule.GetString("passwordChanged"), LogInModule.GetString("passwordMessage"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(LogInModule.GetString("wrongPassword"), LogInModule.GetString("passwordMessage"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(LogInModule.GetString("passwordNotMeetReq"), LogInModule.GetString("registerMessage"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
