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
    public partial class profileForm : Form
    {
        public profileForm()
        {
            InitializeComponent();
            this.Text = LogInModule.GetString("changeLanguage");
            l1.Click += new EventHandler(ChangeToEn);
            l2.Click += new EventHandler(ChangeToEn);
            p1.Click += new EventHandler(ChangeToPl);
            p2.Click += new EventHandler(ChangeToPl);
        }

        private void ChangeToEn(object sender, EventArgs e) { LogInModule.ChangeLanguage("en"); Console.WriteLine("Changed to EN"); }
        private void ChangeToPl(object sender, EventArgs e) { LogInModule.ChangeLanguage("pl"); Console.WriteLine("Changed to PL"); }
    }
}
