using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NStudio.Desktop.Query
{
    public partial class adminInfo : Form
    {
        DatabaseControl dbControl;
        private bool SAResign = false;
        private string state;
        public adminInfo(DatabaseControl dbControl, string state)
        {
            this.dbControl = dbControl;
            this.state = state;
            switch (state)
            {
                case "add":
                    InitializeComponent();
                    FillWithUsers();
                    this.Text = LogInModule.GetString("AddAdminTitle");
                    adminChoiceLabel.Text = LogInModule.GetString("AddAdminLabel");
                    acceptButton.Text = LogInModule.GetString("AddAdminButton");
                    rejectButton.Text = LogInModule.GetString("AddRejectButton");
                    break;

                case "remove":
                    InitializeComponent();
                    FillWithAdmins();
                    this.Text = LogInModule.GetString("RemoveAdminTitle");
                    adminChoiceLabel.Text = LogInModule.GetString("RemoveAdminLabel");
                    acceptButton.Text = LogInModule.GetString("RemoveAdminButton");
                    rejectButton.Text = LogInModule.GetString("RemoveRejectButton");
                    break;

                case "promote":
                    InitializeComponent();
                    FillWithAdmins();
                    this.Text = LogInModule.GetString("PromoteAdminTitle");
                    adminChoiceLabel.Text = LogInModule.GetString("PromoteAdminLabel");
                    acceptButton.Text = LogInModule.GetString("PromoteAdminButton");
                    rejectButton.Text = LogInModule.GetString("PromoteRejectButton");
                    break;

                case "resign":
                    InitializeComponent();
                    FillWithAdmins();
                    this.Text = LogInModule.GetString("PromoteAdminTitle");
                    adminChoiceLabel.Text = LogInModule.GetString("PromoteAdminLabel");
                    acceptButton.Text = LogInModule.GetString("PromoteAdminButton");
                    rejectButton.Text = LogInModule.GetString("PromoteRejectButton");
                    break;

                default:
                    break;
            }
        }

        private void FillWithUsers()
        {
            try
            {
                DataTable usersTable = dbControl.GetUsers();
                adminChoiceBox.Items.Clear();

                foreach (DataRow row in usersTable.Rows)
                {
                    string nick = row["username"].ToString();
                    adminChoiceBox.Items.Add(nick);
                }
                if (adminChoiceBox.Items.Count > 0)
                {
                    adminChoiceBox.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Błąd podczas wypełniania ComboBox: " + ex.Message);
            }
        }

        private void FillWithAdmins()
        {
            try
            {
                DataTable adminsTable = dbControl.GetAdmins();
                adminChoiceBox.Items.Clear();

                foreach (DataRow row in adminsTable.Rows)
                {
                    string nick = row["username"].ToString();
                    adminChoiceBox.Items.Add(nick);
                }
                if (adminChoiceBox.Items.Count > 0)
                {
                    adminChoiceBox.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Błąd podczas wypełniania ComboBox: " + ex.Message);
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (state == "resign")
            {
                if(dbControl.SetUserPower(adminChoiceBox.Text, 3))
                {
                    MessageBox.Show("Poprawnie oddano SuperAdministratora");
                    dbControl.SetUserPower(dbControl.userInfo.Rows[0][1].ToString(), goToPower: 2);
                }
                var result = MessageBox.Show(LogInModule.GetString("resignRequest"),
                                              LogInModule.GetString("resignTitle"),
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Information);

                string exePath = Application.ExecutablePath;
                System.Diagnostics.Process.Start(exePath);
                Application.Exit();
            }
            else if (state == "remove")
            {
                dbControl.SetUserPower(adminChoiceBox.Text, goToPower: 1);
            }
            else if (state == "add")
            {
                dbControl.SetUserPower(adminChoiceBox.Text.ToString(), goToPower: 2);
            }
            else
            {
                MessageBox.Show(LogInModule.GetString("somethingWrong"));
            }
            adminChoiceBox.Items.Clear();
            this.Close();
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            adminChoiceBox.Items.Clear();
            this.Close();
        }
    }
}
