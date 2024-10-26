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

namespace NStudio
{
    public partial class DatabaseControl : Form
    {
        private readonly string connectionString;
        private readonly string databaseType;
        public Action<Color> UpdateLabelColor { get; set; }
        public DatabaseControl()
        {
            InitializeComponent();
        }

        public DatabaseControl(string connectionString, string databaseType)
        {

            this.connectionString = connectionString;
            this.databaseType = databaseType;

        }

        public bool CheckDatabaseConnection()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    UpdateLabelColor.Invoke(Color.Green);
                    return true;
                }
                catch (Exception)
                {
                    UpdateLabelColor.Invoke(Color.Red);
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
                string query = "SELECT COUNT(*) FROM users WHERE username=@username AND password=@password";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                return result > 0;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string dbUsername = "root";
            string dbPassword = "";

            string connectionString = "server=localhost;database=nstudio;uid=root;pwd=;";
        }
    }
}
