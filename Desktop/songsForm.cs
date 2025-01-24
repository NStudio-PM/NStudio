using NStudio.Controls;
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
    public partial class songsForm : Form
    {
        private ToolTip toolTip;
        public DatabaseControl dbControlSongs;
        public readonly string table = "songs";
        private DataTable songs;

        public songsForm(DatabaseControl dbControl)
        {
            InitializeComponent();
            dbControlSongs = dbControl;
            InnitView(Convert.ToInt32(dbControlSongs.userInfo.Rows[0][2]));
            flowPanel.FlowDirection = FlowDirection.TopDown;
            flowPanel.WrapContents = true;
            flowPanel.AutoSize = true;
            flowPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void LoadSongsToFlowPanel(DataTable songsTable, FlowLayoutPanel flowPanel)
        {
            flowPanel.Controls.Clear();

            foreach (DataRow row in songsTable.Rows)
            {
                int id = row["id"] != DBNull.Value ? Convert.ToInt32(row["id"]) : 0;
                string title = row["title"]?.ToString() ?? "Brak nazwy";
                string author = row["author"]?.ToString() ?? "Brak autora";
                string record = row["record"]?.ToString() ?? "Brak albumu";
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

                songsUC songsControl = new songsUC();
                songsControl.SetData(id, title, author, record, year, cost, image);
                flowPanel.Controls.Add(songsControl);
            }
        }

        private void InnitView(int power)
        {
            flowPanel.Dock = DockStyle.Fill;
            flowPanel.FlowDirection = FlowDirection.TopDown;
            flowPanel.WrapContents = true;
            flowPanel.AutoScroll = true;

            songs = dbControlSongs.SongsLoadData();
            LoadSongsToFlowPanel(songs, flowPanel);

            //var uniqueLabels = songs.AsEnumerable().Select(row => row["label"].ToString()).Distinct().ToList();
            //foreach (var label in uniqueLabels) { LabelBox.Items.Add(label); }
            var emptySlot = "";
            if (!LabelBox.Items.Contains(emptySlot)) { LabelBox.Items.Add(emptySlot); }

            toolTip = new ToolTip();
            toolTip.SetToolTip(SongsPlusButton, LogInModule.GetString("aF1Tooltip"));
            toolTip.SetToolTip(SongsMinusButton, LogInModule.GetString("aF2Tooltip"));
            toolTip.SetToolTip(SongsEditButton, LogInModule.GetString("aF3Tooltip"));

            ArtistNameLabel.Text = LogInModule.GetString("artistName");
            ArtistNickLabel.Text = LogInModule.GetString("artistNick");
            ArtistLabelLabel.Text = LogInModule.GetString("artistLabel");

            if (power >= 2)
            {
                SongsPlusButton.Enabled = true;
                SongsMinusButton.Enabled = true;
                SongsEditButton.Enabled = true;
            }
        }

        private void ApplyFilter(string labelFilter, string nameFilter = null, string nicknameFilter = null)
        {
            if (songs != null)
            {
                List<string> filters = new List<string>();

                if (!string.IsNullOrEmpty(labelFilter))
                {
                    filters.Add($"label LIKE '%{labelFilter}%'");
                }

                if (!string.IsNullOrEmpty(nameFilter))
                {
                    filters.Add($"name LIKE '%{nameFilter}%'");
                }

                if (!string.IsNullOrEmpty(nicknameFilter))
                {
                    filters.Add($"nickname LIKE '%{nicknameFilter}%'");
                }

                string filterExpression = string.Join(" AND ", filters);
                DataView view = songs.DefaultView;
                view.RowFilter = filterExpression;
                LoadSongsToFlowPanel(view.ToTable(), flowPanel);
            }
        }

        private void LabelBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ApplyFilter(LabelBox.SelectedItem?.ToString(), nameSearchTextBox.Text, nickSearchTextBox.Text);
        }

        private void nameSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter(LabelBox.SelectedItem?.ToString(), nameSearchTextBox.Text, nickSearchTextBox.Text);
        }

        private void nickSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter(LabelBox.SelectedItem?.ToString(), nameSearchTextBox.Text, nickSearchTextBox.Text);
        }

        private void SongsPlusButton_Click(object sender, EventArgs e)
        {
            songInfo songInfo = new songInfo(dbControlSongs, isEdited: false);
            DataTable data = new DataTable();
            data.Columns.Add("id", typeof(int));
            data.Columns.Add("title", typeof(string));
            data.Columns.Add("author", typeof(string));
            data.Columns.Add("record", typeof(string));
            data.Columns.Add("year", typeof(int));
            data.Columns.Add("cost", typeof(int));
            data.Columns.Add("image", typeof(byte[]));

            songInfo.SetData(data);
            data.Dispose();
            if (songInfo.ShowDialog() == DialogResult.OK)
            {
                songs = dbControlSongs.SongsLoadData();
                LoadSongsToFlowPanel(songs, flowPanel);
            }
        }

        private void SongsMinusButton_Click(object sender, EventArgs e)
        {
            var selectedControls = flowPanel.Controls
                .OfType<songsUC>()
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
                    foreach (var songsUC in selectedControls)
                    {
                        int id = Convert.ToInt32(songsUC.GetSongID());
                        if (dbControlSongs.DeleteRowFromDB(id, "songs"))
                        {
                            flowPanel.Controls.Remove(songsUC);
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

        private void SongsEditButton_Click(object sender, EventArgs e)
        {
            bool isImageNull = false;
            var selectedControls = flowPanel.Controls
                .OfType<songsUC>()
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
                songInfo songInfo = new songInfo(dbControlSongs, isEdited: true);
                int id = Convert.ToInt32(selectedControls[0].GetSongID());
                DataRow[] rows = songs.Select($"id = {id}");
                if (rows.Length > 0)
                {
                    DataRow row = rows[0];
                    string title = row["title"].ToString();
                    string author = row["author"].ToString();
                    string record = row["record"].ToString();
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
                    data.Columns.Add("record", typeof(string));
                    data.Columns.Add("year", typeof(int));
                    data.Columns.Add("cost", typeof(int));
                    data.Columns.Add("image", typeof(byte[]));
                    data.Rows.Add(id, title, author, record, year, cost, imageBlob);

                    songInfo.SetData(data, isImageNull);
                    data.Dispose();
                    if (songInfo.ShowDialog() == DialogResult.OK)
                    {
                        songs = dbControlSongs.SongsLoadData();
                        LoadSongsToFlowPanel(songs, flowPanel);
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