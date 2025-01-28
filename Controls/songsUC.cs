using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NStudio.Controls
{
    public partial class songsUC : UserControl
    {
        private bool isSelected = false;
        public songsUC()
        {
            InitializeComponent();
            songsImage.SizeMode = PictureBoxSizeMode.Zoom;
            LogInModule.ChangeColorColorByTag(this.Controls);
            SongsUCTitleLabel.Text = LogInModule.GetString("SongsUCTitleLabel");
            SongsUCAuthorLabel.Text = LogInModule.GetString("SongsUCAuthorLabel");
            SongsUCRecordLabel.Text = LogInModule.GetString("SongsUCRecordLabel");
            SongsUCYearLabel.Text = LogInModule.GetString("SongsUCYearLabel");
            SongsUCCostLabel.Text = LogInModule.GetString("SongsUCCostLabel");

            this.BackColor = LogInModule.GetColor("up");
            this.Click += SongsUC_Click;
            foreach (Control control in this.Controls)
            {
                control.Click += SongsUC_Click;
            }
        }

        public void SetData(int id, string title, string author, string record, int year, int cost, Image image)
        {
            songsID.Text = $"{id}";
            SUCTitleData.Text = $"{title}";
            SUCAuthorData.Text = $"{author}";
            SUCRecordData.Text = $"{record}";
            SUCYearData.Text = $"{year}";
            SUCCostData.Text = $"{cost/100.0f:F2}" + "  PLN";
            songsImage.Image = image;
        }

        private void SongsUC_Click(object sender, EventArgs e)
        {
            isSelected = !isSelected;
            this.BackColor = isSelected ? LogInModule.GetColor("selected") : LogInModule.GetColor("up");
        }

        public void Deselect()
        {
            isSelected = false;
            this.BackColor = LogInModule.GetColor("up");
        }

        public bool IsSelected()
        {
            return isSelected;
        }

        public int GetSongID()
        {
            return int.Parse(songsID.Text);
        }

        public DataTable GetSongData()
        {
            DataTable data = new DataTable();
            data.Columns.Add("id", typeof(int));
            data.Columns.Add("title", typeof(string));
            data.Columns.Add("author", typeof(string));
            data.Columns.Add("record", typeof(string));
            data.Columns.Add("year", typeof(int));
            data.Columns.Add("cost", typeof(int));
            int id = Convert.ToInt32(songsID.Text);
            int year = Convert.ToInt32(SUCYearData.Text);
            string costText = SUCCostData.Text.Replace(" PLN", "").Trim();
            float costF = float.Parse(costText) * 100.0f;
            int cost = (int)costF;
            data.Rows.Add(id, SUCTitleData.Text, SUCAuthorData.Text, SUCRecordData.Text, year, cost);

            return data;
        }
    }
}
