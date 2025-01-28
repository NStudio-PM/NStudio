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
    public partial class rulesForm : Form
    {
        public rulesForm()
        {
            InitializeComponent();
            this.Text = LogInModule.GetString("rulesForm");
            acceptButton.Text = LogInModule.GetString("acceptButton");
            rejectButton.Text = LogInModule.GetString("rejectButton");
            rulesBox.Text = LogInModule.GetString("rules");
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zapisano regulamin", LogInModule.GetString("rulesForm"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
