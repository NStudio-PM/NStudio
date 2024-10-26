using MySql.Data.MySqlClient;
using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Resources;
using System.Reflection;
using System.Xml.Linq;
using Org.BouncyCastle.Crmf;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NStudio
{
    public partial class DatabaseControl : Form
    {
        private string connectionString;
        private string databaseType;
        private string username;
        private string password;
        public Action<Color> UpdateLabelColor { get; set; }
        public DatabaseControl()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Ustawienie kolorów gradientu
            Color color1 = ColorTranslator.FromHtml("#eeaeca");  // Pierwszy kolor
            Color color2 = ColorTranslator.FromHtml("#c3b4d9");  // Drugi kolor
            Color color3 = ColorTranslator.FromHtml("#94bbe9");  // Trzeci kolor

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

        public DatabaseControl(string connectionString, string databaseType, string username, string password)
        {

            this.connectionString = connectionString;
            this.databaseType = databaseType;
            this.username = username;
            this.password = password;

        }
        public void UpdateConnectionString(string newConnectionString)
        {
            this.connectionString = newConnectionString;
        }

        public bool CheckDatabaseConnection()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                Console.WriteLine(connectionString);
                try
                {
                    connection.Open();
                    UpdateLabelColor?.Invoke(Color.Green);
                    return true;
                }
                catch (Exception)
                {
                    UpdateLabelColor?.Invoke(Color.Red);
                    return false;
                }
            }
            
        }

        public bool ValidateUser(string username, string password)
        {
            /*switch (databaseType)
            {
                case "MySQL":
                    return ValidateUserMySQL(username, password);
                case "PostgreSQL":
                    return ValidateUserPostgreSQL(username, password);
                case "SQLite":
                    return ValidateUserSQLite(username, password);
                case "MongoDB":
                    return ValidateUserMongoDB(username, password);
                default:
                    throw new NotSupportedException($"Unsupported database type: {databaseType}");
            }*/

            return ValidateUserMySQL(username, password);
        }

        private bool ValidateUserMySQL(string username, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT password FROM users WHERE username=@username";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                string hashedPassword = (string)cmd.ExecuteScalar();

                if(hashedPassword != null)
                {
                    bool verify = BCrypt.Net.BCrypt.Verify(password, hashedPassword);
                    hashedPassword = null;
                    password = null;
                    username = null;
                    return verify;
                }
                else
                {
                    hashedPassword = null;
                    password = null;
                    username = null;
                    return false;
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)  // dbSaveButton_Click
        {
            //string dbUsername = "root";
            //string dbPassword = "";
            //string connectionStringTE = "server=localhost;database=nstudio;uid=root;pwd=;";

            Properties.Settings.Default.dbHostname = dbHostname.Text;
            Properties.Settings.Default.dbName = dbName.Text;
            Properties.Settings.Default.dbUser = dbUser.Text;
            Properties.Settings.Default.dbPass = dbPass.Text;

            if (mysql.Checked)
                Properties.Settings.Default.dbType = "mysql";
            else if (postgresql.Checked)
                Properties.Settings.Default.dbType = "postgresql";
            else if (sqlite.Checked)
                Properties.Settings.Default.dbType = "sqlite";
            else if (mongodb.Checked)
                Properties.Settings.Default.dbType = "mongodb";

            Properties.Settings.Default.Save();
            MessageBox.Show(LogInModule.GetString("Aktualizacja po restarcie programu"));
            this.Hide();
        }

        private void dbCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DatabaseControl_Load(object sender, EventArgs e)
        {
            dbHostnameL.Text = LogInModule.GetString("dbHostnameL");
            dbNameL.Text = LogInModule.GetString("dbNameL");
            dbUserL.Text = LogInModule.GetString("dbUserL");
            dbPassL.Text = LogInModule.GetString("dbPassL");
            dbSaveButton.Text = LogInModule.GetString("dbSaveButton");
            dbCancelButton.Text = LogInModule.GetString("dbCancelButton");

            string DHostname = Properties.Settings.Default.dbHostname;
            string DName = Properties.Settings.Default.dbName;
            string DUser = Properties.Settings.Default.dbUser;
            string DPass = Properties.Settings.Default.dbPass;
            string DType = Properties.Settings.Default.dbType;

            dbHostname.Text = DHostname;
            dbName.Text = DName;
            dbUser.Text = DUser;
            dbPass.Text = DPass;
            switch (DType)
                {
                case "mysql":
                    mysql.Checked = true;
                    break;
                case "postgresql":
                    postgresql.Checked = true;
                    break;
                case "sqlite":
                    sqlite.Checked = true;
                    break;
                case "mongodb":
                    mongodb.Checked = true;
                    break;
            }

            //string connectionString = $"server={DHostname};database={DName};uid={DUser};pwd={DPass};";
            //string databaseType = null;
            //string connectionString = "server=localhost;database=nstudio;uid=root;pwd=;";
            //string databaseType = null;
            //dbControl = new DatabaseControl(connectionString, databaseType);
            //dbControl = new DatabaseControl(connectionString, databaseType);
            //DatabaseControl(connectionString, databaseType);
            //dbControl.UpdateLabelColor = UpdateStatusLabelColor;

        }
    }
}
