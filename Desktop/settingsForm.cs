using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace NStudio.Desktop
{
    public partial class settingsForm : Form
    {
        private Dashboard dashboard;
        private bool isEnglish;
        public settingsForm(Dashboard dashboard)
        {
            this.dashboard = dashboard;
            if (Properties.Settings.Default.language == "pl") { isEnglish = false; }
            else { isEnglish = true; }

            InitializeComponent();
            changeLanguageLabel.Text = LogInModule.GetString("changeLanguageLabel");
            logOutLabel.Text = LogInModule.GetString("logOutLabel");
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

        private void logOutButton_Click(object sender, EventArgs e)
        {
            dashboard.logOut();
        }
    }
}
