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
    public partial class recordsUC : UserControl
    {
        private bool isSelected = false;
        public recordsUC()
        {
            InitializeComponent();
            recordsImage.SizeMode = PictureBoxSizeMode.Zoom;
            LogInModule.ChangeColorColorByTag(this.Controls);
            RecordsUCTitleLabel.Text = LogInModule.GetString("SongsUCTitleLabel");
            RecordsUCAuthorLabel.Text = LogInModule.GetString("SongsUCAuthorLabel");
            RecordsUCLabelLabel.Text = LogInModule.GetString("SongsUCRecordLabel");
            RecordsUCYearLabel.Text = LogInModule.GetString("SongsUCYearLabel");
            RecordsUCCostLabel.Text = LogInModule.GetString("SongsUCCostLabel");

            this.BackColor = LogInModule.GetColor("up");
            this.Click += RecordsUC_Click;
            foreach (Control control in this.Controls)
            {
                control.Click += RecordsUC_Click;
            }
        }

        public void SetData(int id, string title, string author, string label, int year, int cost, Image image)
        {
            recordsID.Text = $"{id}";
            RUCTitleData.Text = $"{title}";
            RUCAuthorData.Text = $"{author}";
            RUCLabelData.Text = $"{label}";
            RUCYearData.Text = $"{year}";
            RUCCostData.Text = $"{cost / 100.0f:F2}" + "  PLN";
            recordsImage.Image = image;
        }

        private void RecordsUC_Click(object sender, EventArgs e)
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

        public int GetRecordID()
        {
            return int.Parse(recordsID.Text);
        }

        public DataTable GetRecordData()
        {
            DataTable data = new DataTable();
            data.Columns.Add("id", typeof(int));
            data.Columns.Add("title", typeof(string));
            data.Columns.Add("author", typeof(string));
            data.Columns.Add("label", typeof(string));
            data.Columns.Add("year", typeof(int));
            data.Columns.Add("cost", typeof(int));
            int id = Convert.ToInt32(recordsID.Text);
            int year = Convert.ToInt32(RUCYearData.Text);
            string costText = RUCCostData.Text.Replace(" PLN", "").Trim();
            float costF = float.Parse(costText) * 100.0f;
            int cost = (int)costF;
            data.Rows.Add(id, RUCTitleData.Text, RUCAuthorData.Text, RUCLabelData.Text, year, cost);

            return data;
        }
    }
}
