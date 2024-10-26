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

// TODO COLDERVOID
// remember me checkbox
// reset password label button


namespace NStudio
{
    public partial class LogInModule : Form
    {
        private static ResourceManager _rm;
        private Timer connectionStatusTimer;
        private ToolTip toolTip;
        public DatabaseControl dbControl;
        
        private void ConnectionStatusTimer_Tick(object sender, EventArgs e) { dbControl.CheckDatabaseConnection(); }

        public LogInModule()
        {

            InitializeComponent();
            _rm = new ResourceManager("NStudio.Language.strings", Assembly.GetExecutingAssembly());
            toolTip = new ToolTip();
            toolTip.SetToolTip(lblConnectionStatus, LogInModule.GetString("dbTooltip"));

            string connectionString = "server=localhost;database=nstudio;uid=root;pwd=;";
            string databaseType = null;
            dbControl = new DatabaseControl(connectionString, databaseType);
            dbControl.UpdateLabelColor = UpdateStatusLabelColor;

            // usage example by me
            Console.WriteLine($"{LogInModule.GetString("hello")} {LogInModule.GetString("world")}");
            //LogInModule.ChangeLanguage("en");
            Console.WriteLine($"{LogInModule.GetString("hello")} {LogInModule.GetString("world")}");

            connectionStatusTimer = new Timer();
            connectionStatusTimer.Interval = 5000;
            connectionStatusTimer.Tick += new EventHandler(ConnectionStatusTimer_Tick);
            connectionStatusTimer.Start();


        }

        private void LogInModule_Load(object sender, EventArgs e)
        {

            loginLabel.Text = LogInModule.GetString("loginLabel");
            userInputLabel.Text = LogInModule.GetString("userInputLabel");
            passInputLabel.Text = LogInModule.GetString("passInputLabel");
            loginButton.Text = LogInModule.GetString("loginButton");

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

        private void UpdateStatusLabelColor(Color color)
        {
            lblConnectionStatus.ForeColor = color;
        }

        public static string GetString(string name)
        {
            return _rm.GetString(name);
        }

        public static void ChangeLanguage(string language)
        {

            var cultureInfo = new CultureInfo(language);

            CultureInfo.CurrentCulture = cultureInfo;
            CultureInfo.CurrentUICulture = cultureInfo;

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            string password = passwordInput.Text;

            if (dbControl.CheckDatabaseConnection() && dbControl.ValidateUser(username, password))
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void lblConnectionStatus_Click(object sender, EventArgs e)
        {
            using (var loginform = new DatabaseControl()) { loginform.ShowDialog(); }
        }
    }
}
