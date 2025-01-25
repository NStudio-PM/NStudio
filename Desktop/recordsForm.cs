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

        public recordsForm(DatabaseControl dbControl)
        {
            InitializeComponent();
            dbControlRecords = dbControl;
            InnitView(Convert.ToInt32(dbControlRecords.userInfo.Rows[0][2]));
            flowPanel.FlowDirection = FlowDirection.TopDown;
            flowPanel.WrapContents = true;
            flowPanel.AutoSize = true;
            flowPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        public recordsForm(bool demo)
        {
            InitializeComponent();
            InnitView(0);
            flowPanel.FlowDirection = FlowDirection.TopDown;
            flowPanel.WrapContents = true;
            flowPanel.AutoSize = true;
            flowPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
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

            if (power > 0)
            {
                records = dbControlRecords.RecordsLoadData();
                LoadRecordsToFlowPanel(records, flowPanel);
                var uniqueLabels = records.AsEnumerable().Select(row => row["label"].ToString()).Distinct().ToList();
                foreach (var label in uniqueLabels) { labelBox.Items.Add(label); }
                var emptySlot = "";
                if (!labelBox.Items.Contains(emptySlot)) { labelBox.Items.Add(emptySlot); }
            }
            else if (power >= 2)
            {
                RecordsPlusButton.Enabled = true;
                RecordsMinusButton.Enabled = true;
                RecordsEditButton.Enabled = true;
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
    }
}