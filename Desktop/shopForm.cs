using MongoDB.Driver.Core.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NStudio.Desktop
{
    public partial class shopForm : Form
    {
        DatabaseControl dbControl;
        private Form currentChild;
        public shopForm(DatabaseControl dbControl)
        {
            this.dbControl = dbControl;
            InitializeComponent();
            LogInModule.ChangeColorColorByTag(this.Controls);
            connectButton.Text = LogInModule.GetString("connectButton");
            connectButton2.Text = LogInModule.GetString("connectButton");
        }

        private void OpenChild(Form childForm)
        {
            if (currentChild != null) { currentChild.Close(); }
            currentChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BackColor = LogInModule.GetColor(shade: "down");
            mainPanel.Controls.Add(childForm);
            mainPanel.Tag = childForm;

            topPanel.Visible = false;
            downPanel.Visible = false;

            childForm.BringToFront();
            childForm.Show();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            connectForm connect = new connectForm();
            DialogResult result = connect.ShowDialog();

            if (result == DialogResult.OK)
            {
                OpenChild(new songsForm(dbControl, sales: true));
            }
            else if (result == DialogResult.Yes)
            {
                OpenChild(new recordsForm(dbControl, sales: true));
            }
        }
    }
}
