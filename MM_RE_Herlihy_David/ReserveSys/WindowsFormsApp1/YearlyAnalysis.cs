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
    public partial class frmYearlyAnalysis : Form
    {
        frmMainMenu parent;

        public frmYearlyAnalysis(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }
        public frmYearlyAnalysis()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            chtYear.Show();
            //define chart
            defineChart(dtpYearSelect.Value.Year.ToString().Substring(2, 2));

            //Define the chart series
            defineSeries();

            //Fills the chart with the Revenue of the selected year divided by months
            fillChart(dtpYearSelect.Value.Year.ToString().Substring(2,2));
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void fillChart(string year)
        {

            //fill chart
            chtYear.Series["Revenue"].Points.Clear();

            

            //get data from database
            DataSet ds = new DataSet();
            ds = Reservation.getMonthlyData(ds, year);

            //add values in array to chart series
            int j = 0;
            for (int i = 1; i <= 12; i++)
            {
                if ((j == ds.Tables["ss"].Rows.Count) || (i < Convert.ToInt32(ds.Tables[0].Rows[j][0])))
                    chtYear.Series["Revenue"].Points.AddXY(getMonthName(i), 0);
                else
                {

                    chtYear.Series["Revenue"].Points.AddXY(getMonthName(i), Convert.ToDecimal(ds.Tables[0].Rows[j][1]));
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
            chtYear.Series.Clear();
            chtYear.Series.Add("Revenue");

            chtYear.Series["Revenue"].ChartType = SeriesChartType.Column;
            chtYear.Series["Revenue"].XValueType = ChartValueType.String;
        }

        private void defineChart(string year)
        {
            //define chart
            chtYear.Size = new Size(1000, 500);
            chtYear.ChartAreas[0].Name = "mainArea";
            chtYear.ChartAreas["mainArea"].AxisX.LabelStyle.Font = new Font("Consolas", 8);
            chtYear.ChartAreas["mainArea"].AxisY.LabelStyle.Font = new Font("Consolas", 8);

            chtYear.ChartAreas["mainArea"].AxisY.Minimum = 0;
            chtYear.ChartAreas["mainArea"].AxisY.Interval = 500;
            chtYear.ChartAreas["mainArea"].AxisY.Title = "Euros";

            chtYear.ChartAreas["mainArea"].AxisX.Interval = 1;
            chtYear.ChartAreas["mainArea"].AxisX.Title = "Month";

            chtYear.ChartAreas["mainArea"].AxisX.MajorGrid.Enabled = false;

            //chart title   
            chtYear.Titles.Add("Monthly Revenue 20" + year);
        }
    }
}
