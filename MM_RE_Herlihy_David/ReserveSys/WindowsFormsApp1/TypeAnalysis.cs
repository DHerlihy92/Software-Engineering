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
            if (cboRoomType.Text.Equals(""))
            {
                MessageBox.Show("You did not make a selection.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboRoomType.Focus();
                return;
            }
            if (dtpYearSelect.Text.Equals(""))
            {
                MessageBox.Show("You did not make a selection.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpYearSelect.Focus();
                return;
            }

            picChartType.Show();
        }
    }
}
