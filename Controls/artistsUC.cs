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
    public partial class artistsUC : UserControl
    {
        private bool isSelected = false;

        public artistsUC()
        {
            InitializeComponent();
            artistAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            LogInModule.ChangeColorColorByTag(this.Controls);
            ArtistUCNameLabel.Text = LogInModule.GetString("ArtistUCNameLabel");
            ArtistUCNickLabel.Text = LogInModule.GetString("ArtistUCNickLabel");
            ArtistUCLabelLabel.Text = LogInModule.GetString("ArtistUCLabelLabel");

            this.BackColor = LogInModule.GetColor("up");
            this.Click += ArtistsUC_Click;
            foreach (Control control in this.Controls)
            {
                control.Click += ArtistsUC_Click;
            }
        }

        public void SetData(int id, string name, string nickname, string label, Image avatar)
        {
            artistID.Text = $"{id}";
            AUCNameData.Text = $"{name}";
            AUCNickData.Text = $"{nickname}";
            AUCLabelData.Text = $"{label}";
            artistAvatar.Image = avatar;
        }

        private void ArtistsUC_Click(object sender, EventArgs e)
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

        public int GetArtistID()
        {
            return int.Parse(artistID.Text);
        }
    }
}
