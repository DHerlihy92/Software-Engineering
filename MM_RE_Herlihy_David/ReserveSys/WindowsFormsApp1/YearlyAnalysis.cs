using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (dtpYearSelect.Text.Equals(""))
            {
                MessageBox.Show("You did not make a selection.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpYearSelect.Focus();
                return;
            }

            picChartYear.Show();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }
    }
}
