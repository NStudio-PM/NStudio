using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using NStudio.Desktop;

namespace NStudio
{
    public partial class Dashboard : Form
    {
        private DatabaseControl dbControl;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChild;
        private ToolTip toolTip;
        private readonly struct RGBColors
        {

            public static readonly Color songsColor = Color.FromArgb(158, 205, 250);
            public static readonly Color recordsColor = Color.FromArgb(131, 247, 215);
            public static readonly Color artistsColor = Color.FromArgb(147, 157, 254);
            public static readonly Color shopColor = Color.FromArgb(134, 125, 253);
            public static readonly Color settingsColor = Color.FromArgb(237, 28, 36);

        }
        public Dashboard(DatabaseControl dbControl)
        {
            this.dbControl = dbControl;
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            profileNameLabel.Text = dbControl.userInfo.Rows[0][1].ToString();

            if (!DBNull.Value.Equals(dbControl.userInfo.Rows[0][8]))
            {
                byte[] avatar = (byte[])dbControl.userInfo.Rows[0][8];
                using (MemoryStream avatarStream = new MemoryStream(avatar))
                {
                    Bitmap bitmap = new Bitmap(avatarStream);
                    profileButton.BackgroundImage = bitmap;
                }
            }
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            toolTip = new ToolTip();
            songsButton.Text = LogInModule.GetString("songsButton");
            recordsButton.Text = LogInModule.GetString("recordsButton");
            artistsButton.Text = LogInModule.GetString("artistsButton");
            shopButton.Text = LogInModule.GetString("shopButton");
            settingsButton.Text = LogInModule.GetString("settingsButton");

            toolTip.SetToolTip(profileButton, LogInModule.GetString("d1Tooltip"));
            toolTip.SetToolTip(profileNameLabel, LogInModule.GetString("d1Tooltip"));
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void OpenChild(Form childForm)
        {

            if (currentChild != null) { currentChild.Close(); }
            currentChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BackColor = Color.FromArgb(31, 31, 31);
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

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
            currentChild.Close();

        }

        private void songsButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.songsColor);
            OpenChild(new songsForm());
        }

        private void recordsButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.recordsColor);
            OpenChild(new recordsForm());
        }

        private void artistsButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.artistsColor);
            OpenChild(new artistsForm(dbControl));
        }

        private void shopButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.shopColor);
            OpenChild(new shopForm());
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.settingsColor);
            OpenChild(new settingsForm());
        }

        private void logo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void lblLogo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void profileNameLabel_Click(object sender, EventArgs e)
        {
            profileForm profileForm = new profileForm();
            profileForm.ShowDialog();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            profileForm profileForm = new profileForm();
            profileForm.ShowDialog();
        }
    }
}
