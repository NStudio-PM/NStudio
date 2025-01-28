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
    public partial class connectForm : Form
    {
        public connectForm()
        {
            InitializeComponent();
            LogInModule.ChangeColorColorByTag(this.Controls);

            this.Text = LogInModule.GetString("connectTitle");
            songsLabel.Text = LogInModule.GetString("songsButton");
            recordsLabel.Text = LogInModule.GetString("recordsButton");
        }

        private void songsBox_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void recordsBox_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Yes;
        }
    }
}
