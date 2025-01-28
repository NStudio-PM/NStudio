using NStudio.Controls;
using NStudio.Desktop.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace NStudio.Desktop
{
    public partial class recordsForm : Form
    {
        private ToolTip toolTip;
        public DatabaseControl dbControlRecords;
        public readonly string table = "records";
        private DataTable records;
        private bool sales;

        public recordsForm(DatabaseControl dbControl)
        {
            InitializeComponent();
            dbControlRecords = dbControl;
            InnitView(Convert.ToInt32(dbControlRecords.userInfo.Rows[0][2]));
        }

        public recordsForm(bool demo)
        {
            InitializeComponent();
            InnitView(0);
        }

        public recordsForm(DatabaseControl dbControl, bool sales)
        {
            InitializeComponent();
            this.sales = sales;
            dbControlRecords = dbControl;
            InnitView(Convert.ToInt32(dbControlRecords.userInfo.Rows[0][2]));
        }

        private void LoadRecordsToFlowPanel(DataTable recordsTable, FlowLayoutPanel flowPanel)
        {
            flowPanel.Controls.Clear();

            foreach (DataRow row in recordsTable.Rows)
            {
                int id = row["id"] != DBNull.Value ? Convert.ToInt32(row["id"]) : 0;
                string title = row["title"]?.ToString() ?? "Brak nazwy";
                string author = row["author"]?.ToString() ?? "Brak autora";
                string label = row["label"]?.ToString() ?? "Brak labelu";
                int year = row["year"] != DBNull.Value ? Convert.ToInt32(row["year"]) : 0;
                int cost = row["cost"] != DBNull.Value ? Convert.ToInt32(row["cost"]) : 1234;
                byte[] imageBlob;
                if (row["image"] != DBNull.Value)
                {
                    imageBlob = (byte[])row["image"];
                }
                else
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        Properties.Resources.vinyl.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        imageBlob = ms.ToArray();
                    }
                }
                Image image = null;
                if (imageBlob != null && imageBlob.Length > 0)
                {
                    using (var ms = new MemoryStream(imageBlob))
                    {
                        image = Image.FromStream(ms);
                    }
                }

                recordsUC recordsControl = new recordsUC();
                recordsControl.SetData(id, title, author, label, year, cost, image);
                flowPanel.Controls.Add(recordsControl);
            }
        }

        private void InnitView(int power)
        {
            LogInModule.ChangeColorColorByTag(this.Controls);
            flowPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowPanel.Dock = DockStyle.Fill;
            flowPanel.FlowDirection = FlowDirection.TopDown;
            flowPanel.WrapContents = true;
            flowPanel.AutoScroll = true;
            toolTip = new ToolTip();
            toolTip.SetToolTip(RecordsPlusButton, LogInModule.GetString("aF1Tooltip"));
            toolTip.SetToolTip(RecordsMinusButton, LogInModule.GetString("aF2Tooltip"));
            toolTip.SetToolTip(RecordsEditButton, LogInModule.GetString("aF3Tooltip"));
            titleLabel.Text = LogInModule.GetString("titleLabel-");
            authorLabel.Text = LogInModule.GetString("artistNick");
            labelLabel.Text = LogInModule.GetString("labelLabel-");
            yearLabel.Text = LogInModule.GetString("yearLabel-");

            if (power >= 1)
            {
                records = dbControlRecords.RecordsLoadData();
                LoadRecordsToFlowPanel(records, flowPanel);
                var uniqueLabels = records.AsEnumerable().Select(row => row["label"].ToString()).Distinct().ToList();
                foreach (var label in uniqueLabels) { labelBox.Items.Add(label); }
                var emptySlot = "";
                if (!labelBox.Items.Contains(emptySlot)) { labelBox.Items.Add(emptySlot); }
            }
            if (power >= 2)
            {
                RecordsPlusButton.Enabled = true;
                RecordsMinusButton.Enabled = true;
                RecordsEditButton.Enabled = true;
                salesBox.Enabled = true;
            }
            if (sales)
            {
                RecordsPlusButton.Visible = false;
                RecordsMinusButton.Visible = false;
                RecordsEditButton.Visible = false;
                salesBox.Visible = true;
            }

        }

        private void ApplyFilter(string labelFilter, string titleFilter = null, string authorFilter = null, string yearFilter = null)
        {
            if (records != null)
            {
                List<string> filters = new List<string>();

                if (!string.IsNullOrEmpty(labelFilter))
                {
                    filters.Add($"label LIKE '%{labelFilter}%'");
                }

                if (!string.IsNullOrEmpty(titleFilter))
                {
                    filters.Add($"title LIKE '%{titleFilter}%'");
                }

                if (!string.IsNullOrEmpty(authorFilter))
                {
                    filters.Add($"author LIKE '%{authorFilter}%'");
                }

                if (!string.IsNullOrEmpty(yearFilter))
                {
                    if (int.TryParse(yearFilter, out int year))
                    {
                        filters.Add($"year = {year}");
                    }
                }

                string filterExpression = string.Join(" AND ", filters);
                DataView view = records.DefaultView;
                view.RowFilter = filterExpression;
                LoadRecordsToFlowPanel(view.ToTable(), flowPanel);
            }
        }

        private void LabelBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ApplyFilter(labelBox.SelectedItem?.ToString(), titleSearchBox.Text, authorSearchBox.Text, yearBox.Text);
        }

        private void TitleSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter(labelBox.SelectedItem?.ToString(), titleSearchBox.Text, authorSearchBox.Text, yearBox.Text);
        }

        private void AuthorSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter(labelBox.SelectedItem?.ToString(), titleSearchBox.Text, authorSearchBox.Text, yearBox.Text);
        }

        private void YearSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter(labelBox.SelectedItem?.ToString(), titleSearchBox.Text, authorSearchBox.Text, yearBox.Text);
        }

        private void RecordsPlusButton_Click(object sender, EventArgs e)
        {
            recordInfo recordInfo = new recordInfo(dbControlRecords, isEdited: false);
            DataTable data = new DataTable();
            data.Columns.Add("id", typeof(int));
            data.Columns.Add("title", typeof(string));
            data.Columns.Add("author", typeof(string));
            data.Columns.Add("label", typeof(string));
            data.Columns.Add("year", typeof(int));
            data.Columns.Add("cost", typeof(int));
            data.Columns.Add("image", typeof(byte[]));

            recordInfo.SetData(data);
            data.Dispose();
            if (recordInfo.ShowDialog() == DialogResult.OK)
            {
                records = dbControlRecords.RecordsLoadData();
                LoadRecordsToFlowPanel(records, flowPanel);
            }
        }

        private void RecordsMinusButton_Click(object sender, EventArgs e)
        {
            var selectedControls = flowPanel.Controls
                .OfType<recordsUC>()
                .Where(uc => uc.IsSelected())
                .ToList();

            if (selectedControls.Count > 0)
            {
                DialogResult result = MessageBox.Show(LogInModule.GetString("msgBox1Artist"),
                                                      LogInModule.GetString("msgBox2Artist"),
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (var recordsUC in selectedControls)
                    {
                        int id = Convert.ToInt32(recordsUC.GetRecordID());
                        if (dbControlRecords.DeleteRowFromDB(id, "records"))
                        {
                            flowPanel.Controls.Remove(recordsUC);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(LogInModule.GetString("msgBoxNoSelection"),
                                LogInModule.GetString("msgBoxError"),
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void RecordsEditButton_Click(object sender, EventArgs e)
        {
            bool isImageNull = false;
            var selectedControls = flowPanel.Controls
                .OfType<recordsUC>()
                .Where(uc => uc.IsSelected())
                .ToList();

            if (selectedControls.Count == 0)
            {
                MessageBox.Show(LogInModule.GetString("msgBoxNoSelection"),
                                LogInModule.GetString("msgBoxError"),
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else if (selectedControls.Count == 1)
            {
                recordInfo recordInfo = new recordInfo(dbControlRecords, isEdited: true);
                int id = Convert.ToInt32(selectedControls[0].GetRecordID());
                DataRow[] rows = records.Select($"id = {id}");
                if (rows.Length > 0)
                {
                    DataRow row = rows[0];
                    string title = row["title"].ToString();
                    string author = row["author"].ToString();
                    string label = row["label"].ToString();
                    int year = Convert.ToInt32(row["year"]);
                    int cost = Convert.ToInt32(row["cost"]);
                    byte[] imageBlob;

                    if (row["image"] != DBNull.Value)
                    {
                        imageBlob = (byte[])row["image"];
                    }
                    else
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            isImageNull = true;
                            Properties.Resources.vinyl.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            imageBlob = ms.ToArray();
                        }
                    }

                    DataTable data = new DataTable();
                    data.Columns.Add("id", typeof(int));
                    data.Columns.Add("title", typeof(string));
                    data.Columns.Add("author", typeof(string));
                    data.Columns.Add("label", typeof(string));
                    data.Columns.Add("year", typeof(int));
                    data.Columns.Add("cost", typeof(int));
                    data.Columns.Add("image", typeof(byte[]));
                    data.Rows.Add(id, title, author, label, year, cost, imageBlob);

                    recordInfo.SetData(data, isImageNull);
                    data.Dispose();
                    if (recordInfo.ShowDialog() == DialogResult.OK)
                    {
                        records = dbControlRecords.RecordsLoadData();
                        LoadRecordsToFlowPanel(records, flowPanel);
                    }
                }
            }
            else
            {
                MessageBox.Show(LogInModule.GetString("msgBoxTooManySelections"),
                                LogInModule.GetString("msgBoxError"),
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void salesBox_Click(object sender, EventArgs e)
        {
            var selectedControls = flowPanel.Controls
                .OfType<recordsUC>()
                .Where(uc => uc.IsSelected())
                .ToList();

            if (selectedControls.Count > 0)
            {
                DialogResult result = MessageBox.Show(LogInModule.GetString("msgBox1sales"),
                                                      LogInModule.GetString("msgBox2sales"),
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool fuse = true;
                    string exePath = AppDomain.CurrentDomain.BaseDirectory;
                    DateTimeOffset nowOffset = DateTimeOffset.Now;
                    long unixTimestamp = nowOffset.ToUnixTimeSeconds();
                    string reciptName = "potwierdzenie [" + unixTimestamp + "].txt";
                    string filePath = Path.Combine(exePath, reciptName);
                    string transactionString = "-----------------------------\n";
                    int itemCount = 1;
                    int transactionSum = 0;
                    if (sales)
                    {
                        foreach (var recordsUC in selectedControls)
                        {
                            DataTable data = recordsUC.GetRecordData();
                            int cost = Convert.ToInt32(data.Rows[0][5]);
                            transactionSum += cost;
                        }
                        if (!dbControlRecords.DeductFromBalance(transactionSum))
                        {
                            fuse = false;
                            MessageBox.Show(LogInModule.GetString("msgBox4sales"), "ERR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    transactionSum = 0;

                    if (fuse)
                    {
                        foreach (var recordsUC in selectedControls)
                        {
                            DataTable data = recordsUC.GetRecordData();
                            int id = Convert.ToInt32(data.Rows[0][0]);
                            string title = data.Rows[0][1].ToString();
                            string author = data.Rows[0][2].ToString();
                            string label = data.Rows[0][3].ToString();
                            int year = Convert.ToInt32(data.Rows[0][4]);
                            int cost = Convert.ToInt32(data.Rows[0][5]);

                            DataTable transactionData = new DataTable();
                            transactionData.Columns.Add("type", typeof(string));
                            transactionData.Columns.Add("item_id", typeof(int));
                            transactionData.Columns.Add("cost", typeof(int));
                            transactionData.Columns.Add("user_id", typeof(int));
                            transactionData.Rows.Add("record", id, cost, dbControlRecords.userInfo.Rows[0][0]);
                            dbControlRecords.AddRowToDB(transactionData, table: "transactions");

                            transactionString += "[" + itemCount + "]\n";
                            transactionString += "Typ przedmiotu: PŁYTA\n";
                            transactionString += "Tytuł: " + title + "\n";
                            transactionString += "Autor: " + author + "\n";
                            transactionString += "Label: " + label + "\n\n";
                            transactionString += "Rok wydania: " + year + "\n";
                            transactionString += $"Cena: {cost / 100.0f:F2}" + " PLN\n\n";
                            itemCount++;
                            transactionSum += cost;
                            recordsUC.Deselect();
                        }
                        transactionString += "SUMA: " + $" {transactionSum / 100.0f:F2}" + " PLN\n";
                        transactionString += "-----------------------------\n";
                        File.WriteAllText(filePath, transactionString);
                        MessageBox.Show(LogInModule.GetString("msgBox3sales"), LogInModule.GetString("msgBox2sales"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dbControlRecords.UpdateBalance();
                    }
                }
                else // bez potweirdzenia
                {
                    foreach (var recordsUC in selectedControls)
                    {
                        DataTable data = recordsUC.GetRecordData();
                        int id = Convert.ToInt32(data.Rows[0][0]);
                        int cost = Convert.ToInt32(data.Rows[0][5]);

                        DataTable transactionData = new DataTable();
                        transactionData.Columns.Add("type", typeof(string));
                        transactionData.Columns.Add("item_id", typeof(int));
                        transactionData.Columns.Add("cost", typeof(int));
                        transactionData.Columns.Add("user_id", typeof(int));
                        transactionData.Rows.Add("record", id, cost, dbControlRecords.userInfo.Rows[0][0]);
                        dbControlRecords.AddRowToDB(transactionData, table: "transactions");

                        if (!dbControlRecords.AddRowToDB(data, table: "transactions"))
                        {
                            MessageBox.Show(LogInModule.GetString("somethingWrong"), "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(LogInModule.GetString("msgBoxNoSelection"),
                                LogInModule.GetString("msgBoxError"),
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }
    }
}