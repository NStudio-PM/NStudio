using NStudio.Desktop.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace NStudio.Desktop
{
    public partial class settingsForm : Form
    {
        DatabaseControl dbControl;
        private static ToolTip toolTip;
        private bool isEnglish;
        private bool isDark;
        public settingsForm(DatabaseControl dbControl)
        {
            this.dbControl = dbControl;
            if (Properties.Settings.Default.language == "pl") { isEnglish = false; }
            else { isEnglish = true; }
            if (Properties.Settings.Default.theme == "white") { isDark = false; }
            else { isDark = true; }

            InitializeComponent();
            if (Convert.ToInt32(dbControl.userInfo.Rows[0][2]) >= 2)
            {
                adminSettingsLabel.Visible = true;
                AdminPlusButton.Visible = true;
                AdminMinusButton.Visible = true;
                AdminResignButton.Visible = true;
                adminLevel.Visible = true;
                adminLevelLabel.Visible = true;
                adminDBLabel.Visible = true;
                rulesLabel.Visible = true;
                rulesButton.Visible = true;
            }
            else
            {
                adminSettingsLabel.Visible = false;
                AdminPlusButton.Visible = false;
                AdminMinusButton.Visible = false;
                AdminResignButton.Visible = false;
                adminLevel.Visible = false;
                adminLevelLabel.Visible = false;
                adminDBLabel.Visible = false;
                rulesLabel.Visible = false;
                rulesButton.Visible = false;
            }
            LogInModule.ChangeColorColorByTag(this.Controls);
            toolTip = new ToolTip();
            toolTip.SetToolTip(changeLanguageButton, LogInModule.GetString("changeLanguageLabel"));
            toolTip.SetToolTip(changeThemeButton, LogInModule.GetString("changeThemeLabel"));
            toolTip.SetToolTip(logOutButton, LogInModule.GetString("logOutLabel"));
            toolTip.SetToolTip(AdminMinusButton, LogInModule.GetString("RemoveAdminTitle"));
            toolTip.SetToolTip(AdminPlusButton, LogInModule.GetString("AddAdminTitle"));
            toolTip.SetToolTip(AdminResignButton, LogInModule.GetString("AdminResignButton"));
            userSettingsLabel.Text = LogInModule.GetString("userSettingsLabel");
            adminSettingsLabel.Text = LogInModule.GetString("adminSettingsLabel");
            adminDBLabel.Text = LogInModule.GetString("adminDBLabel");
            changeLanguageLabel.Text = LogInModule.GetString("changeLanguageLabel");
            changeThemeLabel.Text = LogInModule.GetString("changeThemeLabel");
            logOutLabel.Text = LogInModule.GetString("logOutLabel");
            adminLevelLabel.Text = LogInModule.GetString("adminLevelLabel");
            rulesLabel.Text = LogInModule.GetString("rulesTitle");
            adminLevel.Text = dbControl.userInfo.Rows[0][2].ToString();
        }

        public settingsForm(bool demo)
        {
            if (Properties.Settings.Default.language == "pl") { isEnglish = false; }
            else { isEnglish = true; }
            if (Properties.Settings.Default.theme == "white") { isDark = false; }
            else { isDark = true; }

            InitializeComponent();
            toolTip = new ToolTip();
            toolTip.SetToolTip(changeLanguageButton, LogInModule.GetString("changeLanguageLabel"));
            toolTip.SetToolTip(changeThemeButton, LogInModule.GetString("changeThemeLabel"));
            toolTip.SetToolTip(logOutButton, LogInModule.GetString("logOutLabel"));
            toolTip.SetToolTip(AdminMinusButton, LogInModule.GetString("RemoveAdminTitle"));
            toolTip.SetToolTip(AdminPlusButton, LogInModule.GetString("AddAdminTitle"));
            toolTip.SetToolTip(AdminResignButton, LogInModule.GetString("AdminResignButton"));
            userSettingsLabel.Text = LogInModule.GetString("userSettingsLabel");
            adminSettingsLabel.Text = LogInModule.GetString("adminSettingsLabel");
            adminDBLabel.Text = LogInModule.GetString("adminDBLabel");
            changeLanguageLabel.Text = LogInModule.GetString("changeLanguageLabel");
            changeThemeLabel.Text = LogInModule.GetString("changeThemeLabel");
            changeLanguageLabel.Text = LogInModule.GetString("changeLanguageLabel");
            logOutLabel.Text = LogInModule.GetString("logOutLabel");
            adminLevelLabel.Text = LogInModule.GetString("adminLevelLabel");
            adminLevel.Text = "demo";
            adminSettingsLabel.Visible = true;
            changeLanguageButton.Enabled = false;
            changeThemeButton.Enabled = false;
            logOutButton.Enabled = false;
            AdminPlusButton.Enabled = false;
            AdminMinusButton.Enabled = false;
            AdminResignButton.Enabled = false;

        }

        private void changeLanguageButton_Click(object sender, EventArgs e)
        {
            if (isEnglish)
            {
                LogInModule.ChangeLanguage("pl");
                isEnglish = false;
            }
            else
            {
                LogInModule.ChangeLanguage("en");
                isEnglish = true;
            }
        }

        private void changeThemeButton_Click(object sender, EventArgs e)
        {
            if (isDark)
            {
                LogInModule.ChangeTheme("white");
                isDark = false;
            }
            else
            {
                LogInModule.ChangeTheme("dark");
                isDark = true;
            }
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(LogInModule.GetString("logOutRequest"),
                                              LogInModule.GetString("logOutTitle"),
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string exePath = Application.ExecutablePath;
                System.Diagnostics.Process.Start(exePath);
                Application.Exit();
            }
        }

        private void AdminPlusButton_Click(object sender, EventArgs e)
        {
            adminInfo adminInfo = new adminInfo(dbControl, state: "add");
            adminInfo.Show();
        }

        private void AdminMinusButton_Click(object sender, EventArgs e)
        {
            adminInfo adminInfo = new adminInfo(dbControl, state: "remove");
            adminInfo.Show();
        }

        private void AdminResignButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dbControl.userInfo.Rows[0][2]) == 2)
            {
                dbControl.SetUserPower(dbControl.userInfo.Rows[0][1].ToString(), goToPower: 1);
            }
            else
            {
                if (dbControl.GetSAdminCount() <= 1)
                {
                    adminInfo admin = new adminInfo(dbControl, state: "resign");
                    admin.Show();
                }
                else
                {
                    dbControl.SetUserPower(dbControl.userInfo.Rows[0][1].ToString(), goToPower: 2);
                    var result = MessageBox.Show(LogInModule.GetString("resignRequest"),
                                              LogInModule.GetString("resignTitle"),
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Information);

                    string exePath = Application.ExecutablePath;
                    System.Diagnostics.Process.Start(exePath);
                    Application.Exit();
                }
            }
        }

        private void rulesButton_Click(object sender, EventArgs e)
        {
            rulesForm rules = new rulesForm();
            rules.Show();
        }
    }
}
