using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// LanguageModule
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Drawing.Text;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;
using Org.BouncyCastle.Asn1.Crmf;
using System.Web;
using Org.BouncyCastle.Asn1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Diagnostics.Eventing.Reader;
using NStudio.Desktop;

namespace NStudio
{
    public partial class LogInModule : Form
    {
        private static ResourceManager _rm;
        private Timer connectionStatusTimer;
        private ToolTip toolTip;
        public DatabaseControl dbControl;
        public bool dbCreated = false;
        private bool isEnglish;
        private static bool isFirstCall = true;
        public static bool logInSkipMode = false;

        private string DHostname = Properties.Settings.Default.dbHostname;
        public string DName = Properties.Settings.Default.dbName;
        private string DUser = Properties.Settings.Default.dbUser;
        private string DPass = Properties.Settings.Default.dbPass;
        private string DType = Properties.Settings.Default.dbType;


        private async void ConnectionStatusTimer_Tick(object sender, EventArgs e) 
        { 
            await Task.Run(() => dbControl.CheckDatabaseConnection());
            if (!dbCreated)
            {
                dbCreated = await Task.Run(() => dbControl.ValidateDatabase(DName));
            }
        }

        public LogInModule()
        {
            _rm = new ResourceManager("NStudio.Language.strings", Assembly.GetExecutingAssembly());
            string language = Properties.Settings.Default.language;
            LogInModule.ChangeLanguage(language);
            if (Properties.Settings.Default.language == "pl") { isEnglish = false; }
            else { isEnglish = true; }
            if (logInSkipMode)
            {
                Dashboard dashboard = new Dashboard(dbControl);
                dashboard.Show();
            }

            InitializeComponent();
            rPassInput.Visible = false;
            rPassInputLabel.Visible = false;
            rPassPic.Visible = false;
            acceptRulesInput.Visible = false;
            acceptRulesLabel.Visible = false;
            rPassPanel.Visible = false;
            returnButton.Visible = false;
            toolTip = new ToolTip();
            toolTip.SetToolTip(lblConnectionStatus, LogInModule.GetString("dbTooltip"));
            toolTip.SetToolTip(changeLanguageButton, LogInModule.GetString("changeLanguageTooltip"));

            string connectionString = $"server={DHostname};database={DName};uid={DUser};pwd={DPass};";
            string databaseType = DType;
            dbControl = new DatabaseControl(connectionString, databaseType);
            dbControl.userInfo = new DataTable();
            dbControl.UpdateLabelColor = UpdateStatusLabelColor;
            connectionStatusTimer = new Timer();
            connectionStatusTimer.Interval = 5000;
            connectionStatusTimer.Tick += new EventHandler(ConnectionStatusTimer_Tick);
            connectionStatusTimer.Start();

        }

        private void LogInModule_Load(object sender, EventArgs e)
        {

            loginLabel.Text = LogInModule.GetString("loginLabel1");
            userInputLabel.Text = LogInModule.GetString("userInputLabel");
            passInputLabel.Text = LogInModule.GetString("passInputLabel");
            loginButton.Text = LogInModule.GetString("loginButton");
            rPassInputLabel.Text = LogInModule.GetString("rPassInputLabel");
            acceptRulesLabel.Text = LogInModule.GetString("acceptRulesLabel");
            registerButton.Text = LogInModule.GetString("registerButton1");
            returnButton.Text = LogInModule.GetString("returnButton");

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Ustawienie kolorów gradientu
            Color color1 = ColorTranslator.FromHtml("#833ab4");  // Pierwszy kolor
            Color color2 = ColorTranslator.FromHtml("#fd1d1d");  // Drugi kolor
            Color color3 = ColorTranslator.FromHtml("#fcb045");  // Trzeci kolor

            // Utworzenie pędzla gradientowego
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, color1, color2, 45F))
            {
                // Dodanie trzeciego koloru w gradient
                ColorBlend colorBlend = new ColorBlend();
                colorBlend.Colors = new Color[] { color1, color2, color3 };
                colorBlend.Positions = new float[] { 0f, 0.5f, 1f };

                brush.InterpolationColors = colorBlend;

                // Wypełnienie tła formularza gradientem
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }

            base.OnPaint(e);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void UpdateStatusLabelColor(Color color)
        {
            if (lblConnectionStatus.InvokeRequired)
            {
                lblConnectionStatus.Invoke(new Action<Color>(UpdateStatusLabelColor), color);
            }
            else
            {
                lblConnectionStatus.ForeColor = color;
            }
        }

        public static string GetString(string name)
        {
            return _rm.GetString(name);
        }

        public static void ChangeLanguage(string choice)
        {
            if (isFirstCall)
            {
                var cultureInfo = new CultureInfo(choice);
                CultureInfo.CurrentCulture = cultureInfo;
                CultureInfo.CurrentUICulture = cultureInfo;
                isFirstCall = false;
                return;
            }
            if (choice != Properties.Settings.Default.language)
            {
                var result = MessageBox.Show(GetString("changeLanguageRequest"),
                                              GetString("changeLanguageTitle"),
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    Properties.Settings.Default.language = choice;
                    isFirstCall = true;
                    Properties.Settings.Default.Save();
                    var cultureInfo = new CultureInfo(choice);
                    CultureInfo.CurrentCulture = cultureInfo;
                    CultureInfo.CurrentUICulture = cultureInfo;

                    System.Threading.Thread.Sleep(1000);

                    string exePath = Application.ExecutablePath;
                    System.Diagnostics.Process.Start(exePath);
                    Application.Exit();
                }
            }
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            string password = passwordInput.Text;
            bool isConnected = await dbControl.CheckDatabaseConnection();

            if (password.Length >= 0 && username.Length >= 0)
            {
                if (isConnected && dbControl.LoginUser(username, password))
                {
                    connectionStatusTimer.Stop();
                    Dashboard dashboard = new Dashboard(dbControl);
                    this.Hide();
                    dashboard.Show();
                }
                else
                {
                    // edit to red label not alert message
                    MessageBox.Show(LogInModule.GetString("logInError"));
                }
            }
            else
            {
                MessageBox.Show(LogInModule.GetString("logInError"));
            }
        }

        private void lblConnectionStatus_Click(object sender, EventArgs e)
        {
            using (var loginform = new DatabaseControl()) { loginform.ShowDialog(); }
        }

        private async void registerButton_Click(object sender, EventArgs e)
        {
            if (loginButton.Visible)
            {
                loginLabel.Text = LogInModule.GetString("loginLabel2");
                registerButton.Text = LogInModule.GetString("registerButton2");
                loginButton.Visible = false;
                rPassInput.Visible = true;
                rPassInputLabel.Visible = true;
                rPassPic.Visible = true;
                acceptRulesInput.Visible = true;
                acceptRulesLabel.Visible = true;
                rPassPanel.Visible = true;
                returnButton.Visible = true;
            }
            else
            {
                string username = usernameInput.Text;
                string password = passwordInput.Text;
                string rPassword = rPassInput.Text;
                bool isConnected = await dbControl.CheckDatabaseConnection();

                if (password.Length >= 8 && username.Length >= 2 && password == rPassword && acceptRulesInput.Checked)
                {
                    if (isConnected && dbControl.RegisterUser(username, password))
                    {
                        connectionStatusTimer.Stop();
                        Dashboard dashboard = new Dashboard(dbControl);
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        // edit to red label not alert message
                        MessageBox.Show(LogInModule.GetString("registerError"));
                    }
                }
                else
                {
                    MessageBox.Show(LogInModule.GetString("registerError"));
                }
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            loginLabel.Text = LogInModule.GetString("loginLabel1");
            registerButton.Text = LogInModule.GetString("registerButton1");
            loginButton.Visible = true;
            rPassInput.Visible = false;
            rPassInputLabel.Visible = false;
            rPassPic.Visible = false;
            acceptRulesInput.Visible = false;
            acceptRulesLabel.Visible = false;
            rPassPanel.Visible = false;
            returnButton.Visible = false;
        }

        private void LogInModule_FormClosing(object sender, FormClosingEventArgs e) { if (connectionStatusTimer != null) { connectionStatusTimer.Stop(); } }

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

        private void acceptRulesLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(LogInModule.GetString("rules"), LogInModule.GetString("rulesTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
