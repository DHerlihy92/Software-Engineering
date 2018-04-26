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

namespace WindowsFormsApp1
{

    public partial class frmTypeAnalysis : Form
    {
        frmMainMenu parent;

        public frmTypeAnalysis(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }
        public frmTypeAnalysis()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (!Validation.checkEmptyCombo(cboRoomType))
            {
                cboRoomType.Focus();
                return;
            }

            chtType.Show();
            //define chart
            defineChart(dtpYearSelect.Value.Year.ToString().Substring(2, 2));

            //Define the chart series
            defineSeries();

            //fills chart with number of bookings divided by room type
            fillChart(dtpYearSelect.Value.Year.ToString().Substring(2, 2), cboRoomType.Text.Substring(0,2));


        }

        private void fillChart(string year, string type)
        {

            //fill chart
            chtType.Series["Revenue"].Points.Clear();

            //get data from database
            DataSet ds = new DataSet();
            ds = Reservation.getTypeData(ds, year, type);

            //add values in array to chart series
            int j = 0;
            for (int i = 1; i <= 12; i++)
            {
                if ((j == ds.Tables["ss"].Rows.Count) || (i < Convert.ToInt32(ds.Tables[0].Rows[j][0])))
                    chtType.Series["Revenue"].Points.AddXY(getMonthName(i), 0);
                else
                {

                    chtType.Series["Revenue"].Points.AddXY(getMonthName(i), Convert.ToDecimal(ds.Tables[0].Rows[j][1]));
                    j++;
                }
            }
        }

        public String getMonthName(int MonthNo)
        {
            string monthName = "";
            switch (MonthNo)
            {
                case 1:
                    monthName = "JAN";
                    break;
                case 2:
                    monthName = "FEB";
                    break;
                case 3:
                    monthName = "MAR";
                    break;
                case 4:
                    monthName = "APR";
                    break;
                case 5:
                    monthName = "MAY";
                    break;
                case 6:
                    monthName = "JUN";
                    break;
                case 7:
                    monthName = "JUL";
                    break;
                case 8:
                    monthName = "AUG";
                    break;
                case 9:
                    monthName = "SEP";
                    break;
                case 10:
                    monthName = "OCT";
                    break;
                case 11:
                    monthName = "NOV";
                    break;
                case 12:
                    monthName = "DEC";
                    break;
            }
            return monthName;
        }
        private void defineSeries()
        {
            chtType.Series.Clear();
            chtType.Series.Add("Revenue");

            chtType.Series["Revenue"].ChartType = SeriesChartType.Column;
            chtType.Series["Revenue"].XValueType = ChartValueType.String;
        }

        private void defineChart(string year)
        {
            //define chart
            chtType.Size = new Size(1000, 500);
            chtType.ChartAreas[0].Name = "mainArea";
            chtType.ChartAreas["mainArea"].AxisX.LabelStyle.Font = new Font("Consolas", 8);
            chtType.ChartAreas["mainArea"].AxisY.LabelStyle.Font = new Font("Consolas", 8);

            chtType.ChartAreas["mainArea"].AxisY.Minimum = 0;
            chtType.ChartAreas["mainArea"].AxisY.Interval = 50;
            chtType.ChartAreas["mainArea"].AxisY.Title = "Times Booked";

            chtType.ChartAreas["mainArea"].AxisX.Interval = 1;
            chtType.ChartAreas["mainArea"].AxisX.Title = "Month";

            chtType.ChartAreas["mainArea"].AxisX.MajorGrid.Enabled = false;

            //chart title   
            chtType.Titles.Clear();
            chtType.Titles.Add("Monthly Revenue 20" + year);
        }

        private void frmTypeAnalysis_Load(object sender, EventArgs e)
        {
            //Loads all types from Rates File
            DataSet ds = new DataSet();
            cboRoomType.Items.Clear();
            ds = Rates.getAllRates(ds);

            for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
            {
                cboRoomType.Items.Add(ds.Tables[0].Rows[i][0].ToString() + " " + ds.Tables[0].Rows[i][1].ToString());
            }
        }
    }
}
