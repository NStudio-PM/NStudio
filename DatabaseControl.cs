using MySql.Data.MySqlClient;
using Npgsql;
using System.Data.SQLite;
using MongoDB.Driver;
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
using System.Text.Json;

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

        public async Task<bool> ValidateDatabase()
        {
            UpdateLabelColor?.Invoke(Color.Cyan);
            LogInModule logInModule = new LogInModule();
            string dbName = logInModule.DName;
            string blankConnectionString = connectionString.Replace($"database={dbName};", "");

            switch (databaseType)
            {
                case "mysql":
                    try
                    {
                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = @dbName";
                            MySqlCommand cmd = new MySqlCommand(query, connection);
                            cmd.Parameters.AddWithValue("@dbName", dbName);
                            var result = cmd.ExecuteScalar();
                            if (result != null)
                            {
                                // Database exists
                                UpdateLabelColor?.Invoke(Color.LightGreen);
                                return true;
                            }
                            else
                            {
                                throw new InvalidOperationException("Database does not exist");
                            }
                        }
                    }
                    catch (MySqlException ex) when (ex.Number == 1049) // Unknown database error
                    {
                        // Database does not exist
                        try
                        {
                            using (MySqlConnection blankConnection = new MySqlConnection(blankConnectionString))
                            {
                                blankConnection.Open();
                                string createQuery = $"CREATE DATABASE `{dbName}`";
                                MySqlCommand createCmd = new MySqlCommand(createQuery, blankConnection);
                                await createCmd.ExecuteNonQueryAsync();
                                UpdateLabelColor?.Invoke(Color.LightGreen);
                                return true;
                            }
                        }
                        catch (Exception createEx)
                        {
                            UpdateLabelColor?.Invoke(Color.DarkRed);
                            Console.WriteLine($"Error creating database: {createEx.Message}");
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        UpdateLabelColor?.Invoke(Color.DarkRed);
                        Console.WriteLine($"Unexpected error: {ex.Message}");
                        return false;
                    }

                case "postgresql":
                    UpdateLabelColor?.Invoke(Color.DarkRed);
                    return false;
                    /*
                    try
                    {
                        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "SELECT datname FROM pg_database WHERE datname = @dbName";
                            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                            {
                                cmd.Parameters.AddWithValue("@dbName", dbName);
                                var result = cmd.ExecuteScalar();
                                if (result != null)
                                {
                                    // Database exists
                                    UpdateLabelColor?.Invoke(Color.LightGreen);
                                    return true;
                                }
                                else
                                {
                                    throw new InvalidOperationException("Database does not exist");
                                }
                            }
                        }
                    }
                    catch (PostgresException ex) when (ex.SqlState == "3D000") // Undefined database error
                    {
                        // Database does not exist
                        try
                        {
                            using (NpgsqlConnection blankConnection = new NpgsqlConnection(blankConnectionString))
                            {
                                blankConnection.Open();
                                string createQuery = $"CREATE DATABASE \"{dbName}\"";
                                using (NpgsqlCommand createCmd = new NpgsqlCommand(createQuery, blankConnection))
                                {
                                    await createCmd.ExecuteNonQueryAsync();
                                    UpdateLabelColor?.Invoke(Color.LightGreen);
                                    return true;
                                }
                            }
                        }
                        catch (Exception createEx)
                        {
                            UpdateLabelColor?.Invoke(Color.DarkRed);
                            Console.WriteLine($"Error creating database: {createEx.Message}");
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        UpdateLabelColor?.Invoke(Color.DarkRed);
                        Console.WriteLine($"Unexpected error: {ex.Message}");
                        return false;
                    }
                    */
                case "sqlite":
                    UpdateLabelColor?.Invoke(Color.DarkRed);
                    return false;
                    /*
                     

                    try
                    {
                        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                        {
                            connection.Open();
                            // SQLite automatically creates the database if it doesn't exist
                            UpdateLabelColor?.Invoke(Color.LightGreen);
                            return true;
                        }
                    }
                    catch (Exception ex)
                    {
                        UpdateLabelColor?.Invoke(Color.DarkRed);
                        Console.WriteLine($"Unexpected error: {ex.Message}");
                        return false;
                    }
                     
                     */
                case "mongodb":
                    UpdateLabelColor?.Invoke(Color.DarkRed);
                    return false;
                    /*
                    try
                    {
                        var client = new MongoClient(connectionString);
                        var database = client.GetDatabase(dbName);
                        var collection = database.GetCollection<BsonDocument>("dummyCollection");

                        // Check if the database exists by attempting to list collections
                        var collections = database.ListCollectionNames().ToList();
                        if (collections.Any())
                        {
                            // Database exists
                            UpdateLabelColor?.Invoke(Color.LightGreen);
                            return true;
                        }
                        else
                        {
                            // Database does not exist, create it by inserting a dummy document
                            var dummyDocument = new BsonDocument { { "dummy", "value" } };
                            await collection.InsertOneAsync(dummyDocument);
                            UpdateLabelColor?.Invoke(Color.LightGreen);
                            return true;
                        }
                    }
                    catch (Exception ex)
                    {
                        UpdateLabelColor?.Invoke(Color.DarkRed);
                        Console.WriteLine($"Unexpected error: {ex.Message}");
                        return false;
                    }
                    */

                default:
                    UpdateLabelColor?.Invoke(Color.DarkRed);
                    throw new NotSupportedException($"Unsupported database type: {databaseType}");
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
                    UpdateLabelColor?.Invoke(Color.Black);
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

        public DataTable ArtistsLoadData()
        {
            DataTable dataTable = new DataTable();
            switch (databaseType)
            {
                case "mysql":
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            string query = "SELECT * FROM artists";
                            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                            dataAdapter.Fill(dataTable);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        return dataTable;
                    }
                case "postgresql":
                case "sqlite":
                case "mongodb":
                default:
                    dataTable = null;
                    return dataTable;
            }
        }

        public bool DeleteRowFromDB(int id, string table) 
        {
            switch (databaseType)
            {
                case "mysql":
                    string query = $"DELETE FROM {table} WHERE id = @id";
                    using(MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@id", id);
                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch(Exception ex) { MessageBox.Show(ex.Message); return false; }
                        return true;
                    }

                case "postgresql":
                case "sqlite":
                case "mongodb":
                default:
                    return false;
            }
        }

        public DataTable GetUserInfo(string username)
        {
            DataTable dataTable = new DataTable();
            switch (databaseType)
            {
                case "mysql":
                    string infoQuery = "SELECT id, username, power, address, balance FROM users WHERE username=@username";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        MySqlCommand command = new MySqlCommand(infoQuery, connection);
                        command.Parameters.AddWithValue("@username", username);
                        try
                        {
                            connection.Open();
                            MySqlDataAdapter dataAdapter2 = new MySqlDataAdapter(command);
                            dataAdapter2.Fill(dataTable);
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                        return dataTable;
                    }
                case "postgresql":
                case "sqlite":
                case "mongodb":
                default:
                    return dataTable;
            }
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
