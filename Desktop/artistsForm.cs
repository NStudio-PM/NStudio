using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        DataTable artists;
        public artistsForm(DatabaseControl dbControl)
        {
            InitializeComponent();
            dbControlArtists = dbControl;
            LoadDataIntoGrid();
            InnitView(Convert.ToInt32(dbControlArtists.userInfo.Rows[0][2]));
        }

        private void InnitView(int power)
        {
            dataGridArtists.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Black;
            dataGridArtists.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dataGridArtists.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            dataGridArtists.EnableHeadersVisualStyles = false;
            dataGridArtists.Margin = new Padding(0, 0, 0, 0);

            dataGridArtists.RowsDefaultCellStyle.BackColor = System.Drawing.Color.Black;
            dataGridArtists.RowsDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dataGridArtists.RowsDefaultCellStyle.Font = new System.Drawing.Font("Arial", 10);

            dataGridArtists.AlternatingRowsDefaultCellStyle.BackColor= System.Drawing.Color.Gray;
            dataGridArtists.AlternatingRowsDefaultCellStyle.ForeColor= System.Drawing.Color.White;

            dataGridArtists.Columns[0].HeaderText = "ID"; //ID
            dataGridArtists.Columns[1].HeaderText = LogInModule.GetString("artistName"); //nazwa
            dataGridArtists.Columns[2].HeaderText = LogInModule.GetString("artistNick"); //pseudo
            dataGridArtists.Columns[3].HeaderText = LogInModule.GetString("artistLabel"); //label

            dataGridArtists.Columns[0].Width = 50;
            dataGridArtists.Columns[1].Width = 175;
            dataGridArtists.Columns[2].Width = 150;
            dataGridArtists.Columns[3].Width = 150;

            var uniqueLabels = artists.AsEnumerable().Select(row => row["label"].ToString()).Distinct().ToList();
            foreach( var label in uniqueLabels) { LabelBox.Items.Add(label); }

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

        private void LoadDataIntoGrid()
        {
            artists = dbControlArtists.ArtistsLoadData();
            dataGridArtists.DataSource = artists;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridArtists.DataSource as DataTable).DefaultView.RowFilter = string.Format("name LIKE '%{0}%'", nameSearchTextBox.Text);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            (dataGridArtists.DataSource as DataTable).DefaultView.RowFilter = string.Format("nickname LIKE '%{0}%'", nickSearchTextBox.Text);
        }

        private void LabelBox_SelectedValueChanged(object sender, EventArgs e)
        {
            (dataGridArtists.DataSource as DataTable).DefaultView.RowFilter = string.Format("label LIKE '%{0}%'", LabelBox.SelectedItem);
        }

        private void ArtistMinusButton_Click(object sender, EventArgs e)
        {
            if (dataGridArtists.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(LogInModule.GetString("msgBox1Artist"), LogInModule.GetString("msgBox2Artist"), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridArtists.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells["ID"].Value); // dla bazy
                        if (dbControlArtists.DeleteRowFromDB(id, table)) { dataGridArtists.Rows.Remove(row); }
                    }
                }
            }
        }
    }
}
