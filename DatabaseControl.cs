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
using System.Collections;

namespace NStudio
{
    public partial class DatabaseControl : Form
    {
        public readonly string connectionString;
        public readonly string username;
        public readonly int power;
        private readonly string databaseType;
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

        public DatabaseControl(string connectionString, string databaseType)
        {

            this.connectionString = connectionString;
            this.databaseType = databaseType;

        }

        public async Task<bool> CheckDatabaseConnection()
        {
            UpdateLabelColor?.Invoke(Color.Blue);
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync();
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

        public bool ValidateUser(string username, string password, bool register)
        {
            switch (databaseType)
            {
                case "mysql":
                    if (register) { return RegisterUserMySQL(username, password); } else { return LoginUserMySQL(username, password); }
                case "postgresql":
                    if (register) { return RegisterUserPostgreSQL(username, password); } else { return LoginUserPostgreSQL(username, password); }
                case "sqlite":
                    if (register) { return RegisterUserSQLite(username, password); } else { return LoginUserSQLite(username, password); }
                case "mongodb":
                    if (register) { return RegisterUserMongoDB(username, password); } else { return LoginUserMongoDB(username, password); }
                default:
                    throw new NotSupportedException($"Unsupported database type: {databaseType}");
            }
        }

        private bool LoginUserMySQL(string username, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT password FROM users WHERE username=@username";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                string hashedPassword = (string)cmd.ExecuteScalar();
                cmd.Dispose();

                if (hashedPassword != null)
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

        private bool LoginUserPostgreSQL(string username, string password) { return false; }

        private bool LoginUserSQLite(string username, string password) { return false; }

        private bool LoginUserMongoDB(string username, string password) { return false; }

        private bool RegisterUserMySQL(string username, string password) 
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                bool freeUsername = false;
                bool firstUser = false;
                connection.Open();
                string freeQuery = "SELECT COUNT(*) FROM users WHERE username=@username";
                MySqlCommand cmd1 = new MySqlCommand(freeQuery, connection);
                cmd1.Parameters.AddWithValue("@username", username);
                if(Convert.ToInt32(cmd1.ExecuteScalar()) == 0) { freeUsername = true; } else { freeUsername = false; }

                string firstQuery = "SELECT COUNT(*) FROM users";
                MySqlCommand cmd2 = new MySqlCommand(firstQuery, connection);
                if (Convert.ToInt32(cmd2.ExecuteScalar()) == 0) { firstUser = true; } else { firstUser = false; }

                if (freeUsername)
                {
                    int power = 1;
                    if (firstUser) { power = 3; }
                    string registerQuery = "INSERT INTO users (username, password, power) VALUES (@username, @password, @power)";
                    using (MySqlCommand cmd = new MySqlCommand(registerQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", BCrypt.Net.BCrypt.HashPassword(password));
                        cmd.Parameters.AddWithValue("@power", power);

                        cmd.ExecuteNonQuery();
                        password = "";
                    }
                    return true;
                }
                else { return false; }

            }
        }

        private bool RegisterUserPostgreSQL(string username, string password) { return false; }

        private bool RegisterUserSQLite(string username, string password) { return false; }

        private bool RegisterUserMongoDB(string username, string password) { return false; }

        public string SendConnectionString()
        {
            if (connectionString != null) { return connectionString; } else { return ""; }
        }

        private void saveButton_Click(object sender, EventArgs e)  // dbSaveButton_Click
        {

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
            MessageBox.Show(LogInModule.GetString("dbUpdateAfterRestart"));
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
        }
    }
}
