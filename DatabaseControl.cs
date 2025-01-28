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
using System.Runtime.Remoting.Messaging;
using Microsoft.Win32;
using System.IO;
using System.Data.Entity.Infrastructure;

namespace NStudio
{
    public partial class DatabaseControl : Form
    {
        public readonly string connectionString;
        public readonly string username;
        private readonly string databaseType;
        public DataTable userInfo { get; set; }
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
            switch (databaseType)
            {
                case "mysql":
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

                case "postgresql":
                    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
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
                case "sqlite":
                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
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
                case "mongodb":
                    using (MongoClient client = new MongoClient(connectionString))
                    {
                        try
                        {
                            var database = client.GetDatabase("nstudio");                                                   
                            UpdateLabelColor?.Invoke(Color.Green);
                            return true;
                        }
                        catch (Exception)
                        {
                            UpdateLabelColor?.Invoke(Color.Red);
                            return false;
                        }
                    }
                default:
                    UpdateLabelColor?.Invoke(Color.Black);
                    throw new NotSupportedException($"Unsupported database type: {databaseType}");
            }

        }

        public async Task<bool> ValidateDatabase(string dbName)
        {
            UpdateLabelColor?.Invoke(Color.Cyan);
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
                                string createDbQuery = $"CREATE DATABASE `{dbName}`";
                                MySqlCommand createDbCmd = new MySqlCommand(createDbQuery, blankConnection);
                                await createDbCmd.ExecuteNonQueryAsync();

                                string useDbQuery = $"USE `{dbName}`";
                                MySqlCommand useDbCmd = new MySqlCommand(useDbQuery, blankConnection);
                                await useDbCmd.ExecuteNonQueryAsync();

                                string createArtistsTable = @"
                                    CREATE TABLE `artists` (
                                        id INT(11) AUTO_INCREMENT PRIMARY KEY,
                                        name VARCHAR(24),
                                        nickname VARCHAR(24),
                                        label VARCHAR(24),
                                        avatar BLOB
                                    )";

                                string createRecordsTable = @"
                                    CREATE TABLE `records` (
                                        id INT(11) AUTO_INCREMENT PRIMARY KEY,
                                        title VARCHAR(36),
                                        author VARCHAR(36),
                                        label VARCHAR(36),
                                        year INT(11),
                                        cost INT(11),
                                        image BLOB
                                    )";

                                string createSongsTable = @"
                                    CREATE TABLE `songs` (
                                        id INT(11) AUTO_INCREMENT PRIMARY KEY,
                                        title VARCHAR(36),
                                        author VARCHAR(24),
                                        record VARCHAR(24),
                                        year INT(11),
                                        cost INT(11),
                                        image BLOB
                                    )";

                                string createUsersTable = @"
                                    CREATE TABLE `users` (
                                        id INT(11) AUTO_INCREMENT PRIMARY KEY,
                                        username VARCHAR(24),
                                        password VARCHAR(65),
                                        power TINYINT(4),
                                        country VARCHAR(32),
                                        postcode VARCHAR(32),
                                        city VARCHAR(32),
                                        street VARCHAR(32),
                                        balance INT(11) DEFAULT 50000,
                                        avatar BLOB
                                    )";

                                string createTransactionsTable = @"
                                    CREATE TABLE `transactions` (
                                        id INT(11) AUTO_INCREMENT PRIMARY KEY,
                                        type VARCHAR(10),
                                        item_id INT(11),
                                        cost INT(11),
                                        user_id INT(11)
                                    )";

                                var createTableCommands = new List<string> { createArtistsTable, createRecordsTable, createSongsTable, createUsersTable, createTransactionsTable };
                                foreach (var query in createTableCommands)
                                {
                                    MySqlCommand createTableCmd = new MySqlCommand(query, blankConnection);
                                    await createTableCmd.ExecuteNonQueryAsync();
                                }
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
                    try
                    {
                        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "SELECT datname FROM pg_database WHERE datname = @dbName";
                            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
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
                                // Database does not exist
                                UpdateLabelColor?.Invoke(Color.DarkRed);
                                return false;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        UpdateLabelColor?.Invoke(Color.DarkRed);
                        Console.WriteLine($"Unexpected error: {ex.Message}");
                        return false;
                    }
                case "sqlite":
                    try
                    {
                        using (var connection = new SQLiteConnection(connectionString))
                        {
                            connection.Open();
                            // SQLite automatically creates the database file if it does not exist
                            string query = "SELECT name FROM sqlite_master WHERE type='table' AND name='some_table';"; // Replace 'some_table' with a relevant table name
                            SQLiteCommand cmd = new SQLiteCommand(query, connection);
                            var result = cmd.ExecuteScalar();
                            if (result != null)
                            {
                                // Database exists
                                UpdateLabelColor?.Invoke(Color.LightGreen);
                                return true;
                            }
                            else
                            {
                                // Database does not exist
                                UpdateLabelColor?.Invoke(Color.DarkRed);
                                return false;
                            }
                        }
                    }
                    catch (SQLiteException ex)
                    {
                        UpdateLabelColor?.Invoke(Color.DarkRed);
                        Console.WriteLine($"SQLite error: {ex.Message}");
                        return false;
                    }
                    catch (Exception ex)
                    {
                        UpdateLabelColor?.Invoke(Color.DarkRed);
                        Console.WriteLine($"Unexpected error: {ex.Message}");
                        return false;
                    }
                case "mongodb":
                    try
                    {
                        var client = new MongoClient(connectionString);
                        var dbList = client.ListDatabaseNames().ToList();
                        if (dbList.Contains(dbName))
                        {
                            // Database exists
                            UpdateLabelColor?.Invoke(Color.LightGreen);
                            return true;
                        }
                        else
                        {
                            // Database does not exist
                            UpdateLabelColor?.Invoke(Color.DarkRed);
                            return false;
                        }
                    }
                    catch (MongoException ex)
                    {
                        UpdateLabelColor?.Invoke(Color.DarkRed);
                        Console.WriteLine($"MongoDB error: {ex.Message}");
                        return false;
                    }
                    catch (Exception ex)
                    {
                        UpdateLabelColor?.Invoke(Color.DarkRed);
                        Console.WriteLine($"Unexpected error: {ex.Message}");
                        return false;
                    }
                default:
                    UpdateLabelColor?.Invoke(Color.DarkRed);
                    throw new NotSupportedException($"Unsupported database type: {databaseType}");
            }
        }

        public bool LoginUser(string username, string password)
        {
            switch (databaseType)
            {
                case "mysql":
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
                            if (verify)
                            {
                                string infoQuery = "SELECT id, username, power, country, postcode, city, street, balance, avatar FROM users WHERE username=@username";
                                MySqlCommand infoCmd = new MySqlCommand(infoQuery, connection);
                                infoCmd.Parameters.AddWithValue("@username", username);
                                try
                                {
                                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(infoCmd);
                                    dataAdapter.Fill(userInfo);
                                }
                                catch (Exception ex) { MessageBox.Show(ex.Message); }
                            }
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

                case "postgresql":
                    return false;
                case "sqlite":
                    return false;
                case "mongodb":
                    return false;
                default:
                    UpdateLabelColor?.Invoke(Color.Black);
                    throw new NotSupportedException($"Unsupported database type: {databaseType}");
            }
        }

        public bool RegisterUser(string username, string password)
        {
            switch (databaseType)
            {
                case "mysql":
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        bool freeUsername = false;
                        bool firstUser = false;
                        connection.Open();
                        string freeQuery = "SELECT COUNT(*) FROM users WHERE username=@username";
                        MySqlCommand cmd1 = new MySqlCommand(freeQuery, connection);
                        cmd1.Parameters.AddWithValue("@username", username);
                        if (Convert.ToInt32(cmd1.ExecuteScalar()) == 0) { freeUsername = true; } else { freeUsername = false; }

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
                            string infoQuery = "SELECT id, username, power, country, postcode, city, street, balance, avatar FROM users WHERE username=@username";
                            using (MySqlCommand infoCmd = new MySqlCommand(infoQuery, connection))
                            {
                                infoCmd.Parameters.AddWithValue("@username", username);
                                try
                                {
                                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(infoCmd);
                                    dataAdapter.Fill(userInfo);
                                }
                                catch (Exception ex) { MessageBox.Show(ex.Message); }
                            }

                            return true; // rejestracja udana
                        }
                        return false; // uzytkownik zajety

                    }
                case "postgresql":
                    return false;
                case "sqlite":
                    return false;
                case "mongodb":
                    return false;
                default:
                    UpdateLabelColor?.Invoke(Color.Black);
                    throw new NotSupportedException($"Unsupported database type: {databaseType}");
            }
        }

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
                            dataTable = null;
                        }
                        return dataTable;
                    }
                case "postgresql":
                    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            string query = "SELECT * FROM artists";
                            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
                            dataAdapter.Fill(dataTable);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        return dataTable;
                    }
                case "sqlite":
                case "mongodb":
                default:
                    dataTable = null;
                    return dataTable;
            }
        }

        public DataTable SongsLoadData()
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
                            string query = "SELECT * FROM songs";
                            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                            dataAdapter.Fill(dataTable);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            dataTable = null;
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

        public DataTable RecordsLoadData()
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
                            string query = "SELECT * FROM records";
                            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                            dataAdapter.Fill(dataTable);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            dataTable = null;
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

        public DataTable GetUsers()
        {
            DataTable users = new DataTable();
            switch (databaseType)
            {
                case "mysql":
                    int maxPower = 2;
                    string query = "SELECT username FROM users WHERE power < @maxPower";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@maxPower", maxPower);
                                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                                {
                                    adapter.Fill(users);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Błąd podczas pobierania danych: " + ex.Message);
                            users = null;
                        }
                        return users;
                    }
                case "postgresql":
                case "sqlite":
                case "mongodb":
                default:
                    users = null;
                    return users;
            }
        }

        public DataTable GetAdmins()
        {
            DataTable users = new DataTable();
            switch (databaseType)
            {
                case "mysql":
                    int power = 2;
                    string query = "SELECT username FROM users WHERE power = @power";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@power", power);
                                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                                {
                                    adapter.Fill(users);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Błąd podczas pobierania danych: " + ex.Message);
                            users = null;
                        }
                        return users;
                    }
                case "postgresql":
                case "sqlite":
                case "mongodb":
                default:
                    users = null;
                    return users;
            }
        }

        public bool SetUserPower(string username, int goToPower)
        {
            switch (databaseType)
            {
                case "mysql":
                    string query = "UPDATE users SET power = @power WHERE username = @username";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@username", username);
                                command.Parameters.AddWithValue("@power", goToPower);
                                int rowsAffected = command.ExecuteNonQuery();

                                return rowsAffected > 0;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Błąd podczas aktualizacji użytkownika: " + ex.Message);
                            return false;
                        }
                    }
                case "postgresql":
                case "sqlite":
                case "mongodb":
                default:
                    return false;
            }
        }

        public int GetSAdminCount()
        {

            switch (databaseType)
            {
                case "mysql":
                    string query = "SELECT COUNT(*) FROM users WHERE power = 3";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();

                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                object result = command.ExecuteScalar();
                                return Convert.ToInt32(result);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Błąd podczas pobierania liczby użytkowników: " + ex.Message);
                            return 0;
                        }
                    }
                case "postgresql":
                case "sqlite":
                case "mongodb":
                default:
                    return 0;
            }
        }

        public int GetCount(string type)
        {
            switch (databaseType)
            {
                case "mysql":
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        string query = "";
                        if (type == "songs")
                        {
                            query = "SELECT COUNT(*) FROM songs";
                        }
                        else if (type == "records")
                        {
                            query = "SELECT COUNT(*) FROM records";
                        }
                        else if (type == "artists")
                        {
                            query = "SELECT COUNT(*) FROM artists";
                        }
                        else if (type == "income")
                        {
                            query = "SELECT SUM(cost) FROM transactions;";
                        }
                        try
                        {
                            connection.Open();

                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                object result = command.ExecuteScalar();
                                return Convert.ToInt32(result);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Błąd podczas pobierania liczby użytkowników: " + ex.Message);
                            return 0;
                        }
                    }
                case "postgresql":
                case "sqlite":
                case "mongodb":
                default:
                    return 0;
            }
        }

        public bool ChangeUserInfo(DataTable userInfo)
        {
            switch (databaseType)
            {
                case "mysql":
                    string selectQuery = "SELECT id, username, power, country, postcode, city, street, balance, avatar FROM users WHERE id=" + userInfo.Rows[0][0].ToString();
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
                        MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);

                        try
                        {
                            connection.Open();
                            adapter.Update(userInfo);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(LogInModule.GetString("somethingWrong") + ex);
                            // ex, jak na razie nie wysweitlany
                            return false;
                        }
                    }
                    return true;

                case "postgresql":
                case "sqlite":
                case "mongodb":
                default:
                    return false;
            }
        }

        public bool ChangePassword(string oldPassword, string newPassword)
        {
            switch (databaseType)
            {
                case "mysql":
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            string query = "SELECT password FROM users WHERE username=@username";
                            MySqlCommand cmd = new MySqlCommand(query, connection);
                            cmd.Parameters.AddWithValue("@username", userInfo.Rows[0][1].ToString());

                            string hashedPassword = (string)cmd.ExecuteScalar();
                            cmd.Dispose();
                            if (hashedPassword != null)
                            {
                                bool verify = BCrypt.Net.BCrypt.Verify(oldPassword, hashedPassword);
                                if (verify)
                                {
                                    string updateQuery = "UPDATE users SET password=@newPassword WHERE username=@username";
                                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection);
                                    updateCmd.Parameters.AddWithValue("@username", userInfo.Rows[0][1].ToString());
                                    updateCmd.Parameters.AddWithValue("@newPassword", BCrypt.Net.BCrypt.HashPassword(newPassword));

                                    updateCmd.ExecuteNonQuery();
                                    updateCmd.Dispose();

                                    return true;
                                }
                                else
                                {
                                    // wrong old password
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show(LogInModule.GetString("somethingWrong"));
                                // bledy username, zazwyczaj null dziwny
                                return false;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(LogInModule.GetString("somethingWrong") + ex);
                            // ex, jak na razie nie wysweitlany
                            return false;
                        }
                    }

                case "postgresql":
                    return false;
                case "sqlite":
                    return false;
                case "mongodb":
                    return false;
                default:
                    UpdateLabelColor?.Invoke(Color.Black);
                    throw new NotSupportedException($"Unsupported database type: {databaseType}");
            }
        }

        public bool UserExists(string username)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT id FROM users WHERE username=@username";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                var result = cmd.ExecuteScalar();
                cmd.Dispose();

                if (result == null) { return false; }
                return true;
            }
        }

        public bool DeductFromBalance(int cost)
        {
            switch (databaseType)
            {
                case "mysql":
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            string checkBalanceQuery = "SELECT balance FROM users WHERE id = @id";
                            MySqlCommand checkBalanceCommand = new MySqlCommand(checkBalanceQuery, connection);
                            checkBalanceCommand.Parameters.AddWithValue("@id", userInfo.Rows[0][0]);

                            object result = checkBalanceCommand.ExecuteScalar();
                            if (result == null) { return false; }
                            int currentBalance = Convert.ToInt32(result);
                            if (currentBalance >= cost)
                            {
                                string updateBalanceQuery = "UPDATE users SET balance = balance - @cost WHERE id = @id";
                                MySqlCommand updateBalanceCommand = new MySqlCommand(updateBalanceQuery, connection);
                                updateBalanceCommand.Parameters.AddWithValue("@cost", cost);
                                updateBalanceCommand.Parameters.AddWithValue("@id", userInfo.Rows[0][0]);

                                int rowsAffected = updateBalanceCommand.ExecuteNonQuery();
                                return rowsAffected > 0;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Wystąpił błąd: " + ex.Message);
                            return false;
                        }
                    }
                case "postgresql":
                case "sqlite":
                case "mongodb":
                default:
                    return false;
            }
        }

        public void UpdateBalance()
        {
            switch (databaseType)
            {
                case "mysql":
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string infoQuery = "SELECT id, username, power, country, postcode, city, street, balance, avatar FROM users WHERE id=@id";
                        MySqlCommand infoCmd = new MySqlCommand(infoQuery, connection);
                        infoCmd.Parameters.AddWithValue("@id", userInfo.Rows[0][0]);
                        try
                        {
                            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(infoCmd);
                            userInfo.Clear();
                            dataAdapter.Fill(userInfo);
                        }
                        catch (Exception ex) { Console.WriteLine("Wystąpił błąd: " + ex.Message); }
                    }
                    break;
                case "postgresql":
                case "sqlite":
                case "mongodb":
                default:
                    break;
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

        public bool AddRowToDB(DataTable data, string table)
        {
            string insertQuery;
            switch (databaseType)
            {
                case "mysql":
                    switch (table)
                    {
                        case "songs":
                            insertQuery = "INSERT INTO songs (title, author, record, year, cost, image) " +
                                           "VALUES (@title, @author, @record, @year, @cost, @image)";
                            using (MySqlConnection connection = new MySqlConnection(connectionString))
                            {
                                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                                {
                                    connection.Open();
                                    DataRow row = data.Rows[0];
                                    command.Parameters.AddWithValue("@title", row["title"]);
                                    command.Parameters.AddWithValue("@author", row["author"]);
                                    command.Parameters.AddWithValue("@record", row["record"]);
                                    command.Parameters.AddWithValue("@year", Convert.ToInt32(row["year"]));
                                    command.Parameters.AddWithValue("@cost", Convert.ToInt32(row["cost"]));
                                    if (row["image"] != DBNull.Value && row["image"] is byte[] imageBytes)
                                    {
                                        command.Parameters.AddWithValue("@image", imageBytes);
                                    }
                                    else
                                    {
                                        command.Parameters.AddWithValue("@image", DBNull.Value);
                                    }
                                    if (command.ExecuteNonQuery() > 0) { return true; }
                                    else
                                    {
                                        MessageBox.Show(LogInModule.GetString("somethingWrong"));
                                        return false;
                                    }
                                }
                            }

                        case "artists":
                            insertQuery = "INSERT INTO artists (name, nickname, label, avatar) " +
                                          "VALUES (@name, @nickname, @label, @avatar)";
                            using (MySqlConnection connection = new MySqlConnection(connectionString))
                            {
                                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                                {
                                    connection.Open();
                                    DataRow row = data.Rows[0];
                                    command.Parameters.AddWithValue("@name", row["name"]);
                                    command.Parameters.AddWithValue("@nickname", row["nickname"]);
                                    command.Parameters.AddWithValue("@label", row["label"]);
                                    if (row["avatar"] != DBNull.Value && row["avatar"] is byte[] imageBytes)
                                    {
                                        command.Parameters.AddWithValue("@avatar", imageBytes);
                                    }
                                    else
                                    {
                                        command.Parameters.AddWithValue("@avatar", DBNull.Value);
                                    }
                                    if (command.ExecuteNonQuery() > 0) { return true; }
                                    else
                                    {
                                        MessageBox.Show(LogInModule.GetString("somethingWrong"));
                                        return false;
                                    }
                                }
                            }
                        case "records":
                            insertQuery = "INSERT INTO records (title, author, label, year, cost, image) " +
                                           "VALUES (@title, @author, @label, @year, @cost, @image)";
                            using (MySqlConnection connection = new MySqlConnection(connectionString))
                            {
                                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                                {
                                    connection.Open();
                                    DataRow row = data.Rows[0];
                                    command.Parameters.AddWithValue("@title", row["title"]);
                                    command.Parameters.AddWithValue("@author", row["author"]);
                                    command.Parameters.AddWithValue("@label", row["label"]);
                                    command.Parameters.AddWithValue("@year", Convert.ToInt32(row["year"]));
                                    command.Parameters.AddWithValue("@cost", Convert.ToInt32(row["cost"]));
                                    if (row["image"] != DBNull.Value && row["image"] is byte[] imageBytes)
                                    {
                                        command.Parameters.AddWithValue("@image", imageBytes);
                                    }
                                    else
                                    {
                                        command.Parameters.AddWithValue("@image", DBNull.Value);
                                    }
                                    if (command.ExecuteNonQuery() > 0) { return true; }
                                    else
                                    {
                                        MessageBox.Show(LogInModule.GetString("somethingWrong"));
                                        return false;
                                    }
                                }
                            }
                        case "transactions":
                            insertQuery = "INSERT INTO transactions (type, item_id, cost, user_id) " +
                                           "VALUES (@type, @item_id, @cost, @user_id)";
                            using (MySqlConnection connection = new MySqlConnection(connectionString))
                            {
                                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                                {
                                    connection.Open();
                                    DataRow row = data.Rows[0];
                                    command.Parameters.AddWithValue("@type", row["type"]);
                                    command.Parameters.AddWithValue("@item_id", Convert.ToInt32(row["item_id"]));
                                    command.Parameters.AddWithValue("@cost", Convert.ToInt32(row["cost"]));
                                    command.Parameters.AddWithValue("@user_id", Convert.ToInt32(row["user_id"]));
                                    if (command.ExecuteNonQuery() > 0) { return true; }
                                    else
                                    {
                                        MessageBox.Show(LogInModule.GetString("somethingWrong"));
                                        return false;
                                    }
                                }
                            }
                        default:
                            return false;
                    }
                case "postgresql":
                case "sqlite":
                case "mongodb":
                default:
                    return false;
            }

        }

        public bool ChangeRow(DataTable data, int id, string table)
        {
            string updateQuery;
            switch (databaseType)
            {
                case "mysql":
                    switch (table)
                    {
                        case "songs":
                            updateQuery = "UPDATE songs SET " +
                                            "title = @title, " +
                                            "author = @author, " +
                                            "record = @record, " +
                                            "year = @year, " +
                                            "cost = @cost, " +
                                            "image = @image " +
                                            "WHERE id = @id";
                            using (MySqlConnection connection = new MySqlConnection(connectionString))
                            {
                                using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                                {
                                    connection.Open();
                                    DataRow row = data.Rows[0];

                                    command.Parameters.AddWithValue("@id", id);
                                    command.Parameters.AddWithValue("@title", row["title"]);
                                    command.Parameters.AddWithValue("@author", row["author"]);
                                    command.Parameters.AddWithValue("@record", row["record"]);
                                    command.Parameters.AddWithValue("@year", Convert.ToInt32(row["year"]));
                                    command.Parameters.AddWithValue("@cost", Convert.ToInt32(row["cost"]));
                                    var image = row["image"];
                                    if (image != DBNull.Value && image is byte[] imageBytes)
                                    {
                                        command.Parameters.AddWithValue("@image", imageBytes);
                                    }
                                    else
                                    {
                                        command.Parameters.AddWithValue("@image", DBNull.Value);
                                    }

                                    if (command.ExecuteNonQuery() > 0)
                                    {
                                        return true;
                                    }
                                    else
                                    {
                                        MessageBox.Show(LogInModule.GetString("somethingWrong"));
                                        return false;
                                    }
                                }
                            }

                        case "artists":
                            updateQuery = "UPDATE artists SET " +
                                            "name = @name, " +
                                            "nickname = @nickname, " +
                                            "label = @label, " +
                                            "avatar = @avatar " +
                                            "WHERE id = @id";
                            using (MySqlConnection connection = new MySqlConnection(connectionString))
                            {
                                using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                                {
                                    connection.Open();
                                    DataRow row = data.Rows[0];

                                    command.Parameters.AddWithValue("@id", id);
                                    command.Parameters.AddWithValue("@name", row["name"]);
                                    command.Parameters.AddWithValue("@nickname", row["nickname"]);
                                    command.Parameters.AddWithValue("@label", row["label"]);
                                    if (row["avatar"] != DBNull.Value && row["avatar"] is byte[] imageBytes)
                                    {
                                        command.Parameters.AddWithValue("@avatar", imageBytes);
                                    }
                                    else
                                    {
                                        command.Parameters.AddWithValue("@avatar", DBNull.Value);
                                    }

                                    if (command.ExecuteNonQuery() > 0)
                                    {
                                        return true;
                                    }
                                    else
                                    {
                                        MessageBox.Show(LogInModule.GetString("somethingWrong"));
                                        return false;
                                    }
                                }
                            }

                        case "records":
                            updateQuery = "UPDATE records SET " +
                                            "title = @title, " +
                                            "author = @author, " +
                                            "label = @label, " +
                                            "year = @year, " +
                                            "cost = @cost, " +
                                            "image = @image " +
                                            "WHERE id = @id";
                            using (MySqlConnection connection = new MySqlConnection(connectionString))
                            {
                                using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                                {
                                    connection.Open();
                                    DataRow row = data.Rows[0];

                                    command.Parameters.AddWithValue("@id", id);
                                    command.Parameters.AddWithValue("@title", row["title"]);
                                    command.Parameters.AddWithValue("@author", row["author"]);
                                    command.Parameters.AddWithValue("@label", row["label"]);
                                    command.Parameters.AddWithValue("@year", Convert.ToInt32(row["year"]));
                                    command.Parameters.AddWithValue("@cost", Convert.ToInt32(row["cost"]));
                                    if (row["image"] != DBNull.Value && row["image"] is byte[] imageBytes)
                                    {
                                        command.Parameters.AddWithValue("@image", imageBytes);
                                    }
                                    else
                                    {
                                        command.Parameters.AddWithValue("@image", DBNull.Value);
                                    }

                                    if (command.ExecuteNonQuery() > 0)
                                    {
                                        return true;
                                    }
                                    else
                                    {
                                        MessageBox.Show(LogInModule.GetString("somethingWrong"));
                                        return false;
                                    }
                                }
                            }

                        default:
                            return false;
                    }

                case "postgresql":
                case "sqlite":
                case "mongodb":
                default:
                    return false;
            }
        }

        public bool CompareTwoUserInfo(DataTable originalUserInfo, DataTable newUserInfo)
        {
            for (int i = 0; i < originalUserInfo.Columns.Count; i++)
            {
                if (i == 8)
                {
                    if(originalUserInfo.Rows[0][i] == DBNull.Value && newUserInfo.Rows[0][i] is byte[])
                    {
                        return false;
                    }
                    if (originalUserInfo.Rows[0][i] is byte[] byteArray1 && newUserInfo.Rows[0][i] is byte[] byteArray2)
                    {
                        if (!CompareTwoByteTable(byteArray1, byteArray2)) { return false; }
                    }
                }
                else
                {
                    if (originalUserInfo.Rows[0][i].ToString() != newUserInfo.Rows[0][i].ToString()) { return false; }
                }
            }
            return true;
        }

        public bool CompareTwoDataTable(DataTable originalDataTable, DataTable newDataTable)
        {
            for (int i = 0; i < originalDataTable.Columns.Count; i++)
            {
                if (originalDataTable.Rows[0][i] is byte[])
                {
                    if (originalDataTable.Rows[0][i] is byte[] byteArray1 && newDataTable.Rows[0][i] is byte[] byteArray2)
                        if (!CompareTwoByteTable(byteArray1, byteArray2)) { return false; }
                }
                else
                {
                    if (originalDataTable.Rows[0][i].ToString() != newDataTable.Rows[0][i].ToString()) { return false; }
                }
            }
            return true;
        }

        public bool CompareTwoByteTable(byte[] byteArray1, byte[] byteArray2)
        {
            if (byteArray1.Length != byteArray2.Length) { return false; }
            for (int i = 0; i < byteArray1.Length; i++)
            {
                if (byteArray1[i] != byteArray2[i])
                {
                    return false;
                }
            }
            return true;
        }

        public byte[] AvatarToByteArray(PictureBox pictureBox)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                pictureBox.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                return memoryStream.ToArray();
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
            System.Threading.Thread.Sleep(500);

            string exePath = Application.ExecutablePath;
            System.Diagnostics.Process.Start(exePath);
            Application.Exit();
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
