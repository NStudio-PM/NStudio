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
            SongsUCTitleLabel.Text = LogInModule.GetString("SongsUCTitleLabel");
            SongsUCAuthorLabel.Text = LogInModule.GetString("SongsUCAuthorLabel");
            SongsUCRecordLabel.Text = LogInModule.GetString("SongsUCRecordLabel");
            SongsUCYearLabel.Text = LogInModule.GetString("SongsUCYearLabel");
            SongsUCCostLabel.Text = LogInModule.GetString("SongsUCCostLabel");

            this.BackColor = Color.FromArgb(41, 41, 41);
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
            this.BackColor = isSelected ? Color.FromArgb(51, 51, 51) : Color.FromArgb(41, 41, 41);
        }

        public void Deselect()
        {
            isSelected = false;
            this.BackColor = Color.FromArgb(41, 41, 41);
        }

        public bool IsSelected()
        {
            return isSelected;
        }

        public int GetSongID()
        {
            return int.Parse(songsID.Text);
        }
    }
}
