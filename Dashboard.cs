using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NStudio
{
    public partial class Dashboard : Form
    {
        private DatabaseControl dbControl;
        public Dashboard(DatabaseControl dbControl)
        {
            InitializeComponent();
            this.dbControl = dbControl;

            //string cs = dbControl.connectionString;
            //string cs = dbControl.SendConnectionString();
            //Console.WriteLine(cs);
        }
    }
}
