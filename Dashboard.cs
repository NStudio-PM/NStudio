using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace NStudio
{
    public partial class Dashboard : Form
    {
        private DatabaseControl dbControl;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private struct RGBColors
        {

            public static readonly Color songsColor = Color.FromArgb(158, 205, 250);
            public static readonly Color recordsColor = Color.FromArgb(131, 247, 215);
            public static readonly Color artistsColor = Color.FromArgb(147, 157, 254);
            public static readonly Color shopColor = Color.FromArgb(134, 125, 253);
            public static readonly Color settingsColor = Color.FromArgb(237, 28, 36);

        }
        public Dashboard(DatabaseControl dbControl)
        {
            InitializeComponent();
            this.dbControl = dbControl;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            //string cs = dbControl.connectionString;
            //string cs = dbControl.SendConnectionString();
            //Console.WriteLine(cs);
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            songsButton.Text = LogInModule.GetString("songsButton");
            recordsButton.Text = LogInModule.GetString("recordsButton");
            artistsButton.Text = LogInModule.GetString("artistsButton");
            shopButton.Text = LogInModule.GetString("shopButton");
            settingsButton.Text = LogInModule.GetString("settingsButton");
        }

        private void ActivateButton(object sender, Color color)
        {
            if (sender != null)
            {
                DeactivateButton();
                currentBtn = (IconButton)sender;
                currentBtn.BackColor = Color.FromArgb(31, 31, 31);
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DeactivateButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(41, 41, 41);
                currentBtn.ForeColor = Color.White;
                currentBtn.IconColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Reset()
        {

            DeactivateButton();
            leftBorderBtn.Visible = false;

        }

        private void songsButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.songsColor);
        }

        private void recordsButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.recordsColor);
        }

        private void artistsButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.artistsColor);
        }

        private void shopButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.shopColor);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.settingsColor);
        }

        private void logo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void lblLogo_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
