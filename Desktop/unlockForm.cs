using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace NStudio.Desktop
{
    public partial class unlockForm : Form
    {
        private bool isPassEntered = false;
        readonly private bool unlockRequest = false;
        public unlockForm(bool unlockRequest)
        {
            this.unlockRequest = unlockRequest;
            InitializeComponent();
            this.Text = LogInModule.GetString("unlockTitle");
            unlockLabel.Text = LogInModule.GetString("lockLabel");
            acceptButton.Text = LogInModule.GetString("acceptButton");
        }
        public unlockForm()
        {
            InitializeComponent();
            this.Text = LogInModule.GetString("lockTitle");
            unlockLabel.Text = LogInModule.GetString("lockTitle");
            acceptButton.Text = LogInModule.GetString("acceptButton");
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (unlockTextBox.Text == LogInModule.GetUnlockPassword() && unlockRequest)
            {
                isPassEntered = false;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (unlockTextBox.Text != LogInModule.GetUnlockPassword() && unlockRequest)
            {
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
            else
            {
                LogInModule.SetUnlockPassword(unlockTextBox.Text);
                isPassEntered = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
