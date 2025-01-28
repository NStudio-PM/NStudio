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
        private bool demo = false;
        private readonly struct RGBColors
        {

            public static readonly Color songsColor = Color.FromArgb(158, 205, 250);
            public static readonly Color recordsColor = Color.FromArgb(131, 247, 215);
            public static readonly Color artistsColor = Color.FromArgb(147, 157, 254);
            public static readonly Color shopColor = Color.FromArgb(134, 125, 253);
            public static readonly Color settingsColor = Color.FromArgb(237, 28, 36);
            public static readonly Color unlockColor = Color.FromArgb(232, 63, 111);

        }
        public Dashboard(DatabaseControl dbControl)
        {
            this.dbControl = dbControl;
            this.KeyPreview = true;
            this.KeyDown += Dashboard_KeyDown;
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            profileNameLabel.Text = dbControl.userInfo.Rows[0][1].ToString();
            unlockButton.Visible = false;

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

        // demo mode activated
        public Dashboard(DatabaseControl dbControl, bool demo)
        {
            this.dbControl = dbControl;
            this.demo = demo;
            this.KeyPreview = true;
            this.KeyDown += Dashboard_KeyDown;
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            profileNameLabel.Text = "demo";
            unlockButton.Visible = true;
            this.ControlBox = false;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LogInModule.ChangeColorColorByTag(this.Controls);
            toolTip = new ToolTip();
            songsButton.Text = LogInModule.GetString("songsButton");
            recordsButton.Text = LogInModule.GetString("recordsButton");
            artistsButton.Text = LogInModule.GetString("artistsButton");
            shopButton.Text = LogInModule.GetString("shopButton");
            settingsButton.Text = LogInModule.GetString("settingsButton");
            incomeLabel.Text = LogInModule.GetString("incomeLabel");
            songsCountLabel.Text = LogInModule.GetString("songsCountLabel");
            recordsCountLabel.Text = LogInModule.GetString("recordsCountLabel");
            artistsCountLabel.Text = LogInModule.GetString("artistsCountLabel");
            unlockButton.Text = LogInModule.GetString("unlockButton");
            moneyLabel.Text = LogInModule.GetString("moneyLabel");
            if (!demo)
            {
                dbName.Text = Properties.Settings.Default.dbName + "  @" + Properties.Settings.Default.dbHostname;
                moneyBox.Text = $"{Convert.ToInt32(dbControl.userInfo.Rows[0][7]) / 100.0f:F2}" + "  PLN";
            }
            else
            {
                dbName.Text = "demo  @localhost";
                moneyBox.Text = "N/A";
            }

            toolTip.SetToolTip(profileButton, LogInModule.GetString("d1Tooltip"));
            toolTip.SetToolTip(profileNameLabel, LogInModule.GetString("d1Tooltip"));

            incomeBox.Text = $"{dbControl.GetCount(type: "income") / 100.0f:F2}" + "  PLN";
            artistsCount.Text = dbControl.GetCount(type: "artists").ToString();
            recordsCount.Text = dbControl.GetCount(type: "records").ToString();
            songsCount.Text = dbControl.GetCount(type: "songs").ToString();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void Dashboard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                e.SuppressKeyPress = true;
                songsButton_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.R)
            {
                e.SuppressKeyPress = true;
                recordsButton_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.A)
            {
                e.SuppressKeyPress = true;
                artistsButton_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.H)
            {
                e.SuppressKeyPress = true;
                shopButton_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.E)
            {
                e.SuppressKeyPress = true;
                settingsButton_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.P)
            {
                e.SuppressKeyPress = true;
                profileButton_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.D)
            {
                e.SuppressKeyPress = true;
                Reset();
            }
            else if (e.Control && e.KeyCode == Keys.U)
            {
                e.SuppressKeyPress = true;
                unlockButton_Click(sender, e);
            }
        }

        private void OpenChild(Form childForm)
        {
            if (currentChild != null) { currentChild.Close(); }
            currentChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BackColor = LogInModule.GetColor(shade: "down");
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActivateButton(object sender, Color color)
        {
            if (sender != null && sender is IconButton button)
            {
                DeactivateButton();
                currentBtn = (IconButton)sender;
                currentBtn.BackColor = LogInModule.GetColor(shade: "down");
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
                currentBtn.BackColor = LogInModule.GetColor(shade: "up");
                currentBtn.ForeColor = LogInModule.GetColor(shade: "font");
                currentBtn.IconColor = LogInModule.GetColor(shade: "font");
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Reset()
        {
            DeactivateButton();
            if(leftBorderBtn.Visible) { leftBorderBtn.Visible = false; }
            if (currentChild != null) { currentChild.Close(); }
            moneyBox.Text = $"{Convert.ToInt32(dbControl.userInfo.Rows[0][7]) / 100.0f:F2}" + "  PLN";
        }

        private void songsButton_Click(object sender, EventArgs e)
        {
            if (!demo)
            {
                ActivateButton(sender, RGBColors.songsColor);
                OpenChild(new songsForm(dbControl));
            }
            else
            {
                ActivateButton(sender, RGBColors.songsColor);
                OpenChild(new songsForm(demo: true));
            }
        }

        private void recordsButton_Click(object sender, EventArgs e)
        {
            if (!demo)
            {
                ActivateButton(sender, RGBColors.recordsColor);
                OpenChild(new recordsForm(dbControl));
            }
            else
            {
                ActivateButton(sender, RGBColors.recordsColor);
                OpenChild(new recordsForm(demo: true));
            }
        }

        private void artistsButton_Click(object sender, EventArgs e)
        {
            if (!demo)
            {
                ActivateButton(sender, RGBColors.artistsColor);
                OpenChild(new artistsForm(dbControl));
            }
            else
            {
                ActivateButton(sender, RGBColors.artistsColor);
                OpenChild(new artistsForm(demo: true));
            }
        }

        private void shopButton_Click(object sender, EventArgs e)
        {
            if (!demo)
            {
                ActivateButton(sender, RGBColors.shopColor);
                OpenChild(new shopForm(dbControl));
                moneyBox.Text = $"{Convert.ToInt32(dbControl.userInfo.Rows[0][7]) / 100.0f:F2}" + "  PLN";
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            if (!demo)
            {
                ActivateButton(sender, RGBColors.settingsColor);
                OpenChild(new settingsForm(dbControl));
            }
            else
            {
                ActivateButton(sender, RGBColors.settingsColor);
                OpenChild(new settingsForm(demo: true));
            }
        }

        private void unlockButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.unlockColor);
            unlockForm unlockForm = new unlockForm(unlockRequest: true);
            DialogResult result = unlockForm.ShowDialog();
            DeactivateButton();
            if(result == DialogResult.OK)
            {
                string exePath = Application.ExecutablePath;
                System.Diagnostics.Process.Start(exePath);
                Application.Exit();
            }
            else if (result == DialogResult.Abort)
            {
                MessageBox.Show(LogInModule.GetString("badUnlockMsg"), LogInModule.GetString("unlockTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            if (!demo)
            {
                profileForm profileForm = new profileForm(dbControl);
                profileForm.ShowDialog();

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
        }
    }
}
