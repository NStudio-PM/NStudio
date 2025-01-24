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

namespace NStudio.Desktop
{
    public partial class artistsForm : Form
    {
        private ToolTip toolTip;
        public DatabaseControl dbControlArtists;
        public readonly string table = "artists";
        private DataTable artists;

        public artistsForm(DatabaseControl dbControl)
        {
            InitializeComponent();
            dbControlArtists = dbControl;
            InnitView(Convert.ToInt32(dbControlArtists.userInfo.Rows[0][2]));
            flowPanel.FlowDirection = FlowDirection.TopDown;
            flowPanel.WrapContents = true;
            flowPanel.AutoSize = true;
            flowPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void LoadArtistsToFlowPanel(DataTable artistsTable, FlowLayoutPanel flowPanel)
        {
            flowPanel.Controls.Clear();

            foreach (DataRow row in artistsTable.Rows)
            {
                int id = row["id"] != DBNull.Value ? Convert.ToInt32(row["id"]) : 0;
                string name = row["name"]?.ToString() ?? "Brak nazwy";
                string nickname = row["nickname"]?.ToString() ?? "Brak pseudonimu";
                string label = row["label"]?.ToString() ?? "Brak labelu";
                byte[] avatarBlob;
                if (row["avatar"] != DBNull.Value)
                {
                    avatarBlob = (byte[])row["avatar"];
                }
                else
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        Properties.Resources.defaultAvatar.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        avatarBlob = ms.ToArray();
                    }
                }
                Image avatar = null;
                if (avatarBlob != null && avatarBlob.Length > 0)
                {
                    using (var ms = new MemoryStream(avatarBlob))
                    {
                        avatar = Image.FromStream(ms);
                    }
                }

                artistsUC artistControl = new artistsUC();
                artistControl.SetData(id, name, nickname, label, avatar);
                flowPanel.Controls.Add(artistControl);
            }
        }

        private void InnitView(int power)
        {
            flowPanel.Dock = DockStyle.Fill;
            flowPanel.FlowDirection = FlowDirection.TopDown;
            flowPanel.WrapContents = true;
            flowPanel.AutoScroll = true;

            artists = dbControlArtists.ArtistsLoadData();
            LoadArtistsToFlowPanel(artists, flowPanel);

            var uniqueLabels = artists.AsEnumerable().Select(row => row["label"].ToString()).Distinct().ToList();
            foreach (var label in uniqueLabels) { LabelBox.Items.Add(label); }
            var emptySlot = "";
            if (!LabelBox.Items.Contains(emptySlot)) {  LabelBox.Items.Add(emptySlot); }

            toolTip = new ToolTip();
            toolTip.SetToolTip(ArtistPlusButton, LogInModule.GetString("aF1Tooltip"));
            toolTip.SetToolTip(ArtistMinusButton, LogInModule.GetString("aF2Tooltip"));
            toolTip.SetToolTip(ArtistEditButton, LogInModule.GetString("aF3Tooltip"));

            ArtistNameLabel.Text = LogInModule.GetString("artistName");
            ArtistNickLabel.Text = LogInModule.GetString("artistNick");
            ArtistLabelLabel.Text = LogInModule.GetString("artistLabel");

            if (power >= 2)
            {
                ArtistPlusButton.Enabled = true;
                ArtistMinusButton.Enabled = true;
                ArtistEditButton.Enabled = true;
            }
        }

        private void ApplyFilter(string labelFilter, string nameFilter = null, string nicknameFilter = null)
        {
            if (artists != null)
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
                DataView view = artists.DefaultView;
                view.RowFilter = filterExpression;
                LoadArtistsToFlowPanel(view.ToTable(), flowPanel);
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

        private void ArtistMinusButton_Click(object sender, EventArgs e)
        { 
            var selectedControls = flowPanel.Controls
                .OfType<artistsUC>()
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
                    foreach (var artistUC in selectedControls)
                    {
                        int id = Convert.ToInt32(artistUC.GetArtistID());
                        if (dbControlArtists.DeleteRowFromDB(id, "artists"))
                        {
                            flowPanel.Controls.Remove(artistUC);
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

        private void ArtistEditButton_Click(object sender, EventArgs e)
        {
            bool isImageNull = false;
            var selectedControls = flowPanel.Controls
                .OfType<artistsUC>()
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
                artistInfo artistInfo = new artistInfo(dbControlArtists, isEdited: true);
                int id = Convert.ToInt32(selectedControls[0].GetArtistID());
                DataRow[] rows = artists.Select($"id = {id}");
                if (rows.Length > 0)
                {
                    DataRow row = rows[0];
                    string name = row["name"].ToString();
                    string nickname = row["nickname"].ToString();
                    string label = row["label"].ToString();
                    byte[] imageBlob;

                    if (row["avatar"] != DBNull.Value)
                    {
                        imageBlob = (byte[])row["avatar"];
                    }
                    else
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            Properties.Resources.defaultAvatar.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            imageBlob = ms.ToArray();
                        }
                    }

                    DataTable data = new DataTable();
                    data.Columns.Add("id", typeof(int));
                    data.Columns.Add("name", typeof(string));
                    data.Columns.Add("nickname", typeof(string));
                    data.Columns.Add("label", typeof(string));
                    data.Columns.Add("avatar", typeof(byte[]));
                    data.Rows.Add(id, name, nickname, label, imageBlob);

                    artistInfo.SetData(data, isImageNull);
                    data.Dispose();
                    if (artistInfo.ShowDialog() == DialogResult.OK)
                    {
                        artists = dbControlArtists.ArtistsLoadData();
                        LoadArtistsToFlowPanel(artists, flowPanel);
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

        private void ArtistPlusButton_Click(object sender, EventArgs e)
        {
            artistInfo artistInfo = new artistInfo(dbControlArtists, isEdited: false);
            DataTable data = new DataTable();
            data.Columns.Add("id", typeof(int));
            data.Columns.Add("name", typeof(string));
            data.Columns.Add("nickname", typeof(string));
            data.Columns.Add("label", typeof(string));
            data.Columns.Add("avatar", typeof(byte[]));

            artistInfo.SetData(data);
            data.Dispose();
            if (artistInfo.ShowDialog() == DialogResult.OK)
            {
                artists = dbControlArtists.ArtistsLoadData();
                LoadArtistsToFlowPanel(artists, flowPanel);
            }
        }
    }
}