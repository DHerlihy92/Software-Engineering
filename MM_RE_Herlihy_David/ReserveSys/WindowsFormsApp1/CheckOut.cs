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
    public partial class frmCheckOut : Form
    {
        frmMainMenu parent;

        public frmCheckOut(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }
        public frmCheckOut()
        {
            InitializeComponent();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void btnSelectRes_Click(object sender, EventArgs e)
        {
            //Validating Data
            if (cboSelectRes.Text.Equals(""))
            {
                MessageBox.Show("This field must be selected.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboSelectRes.Focus();
                return;
            }

            //Display Yes/No dialog to confirm Reservation
            DialogResult dResult = MessageBox.Show("Are you sure this reservation is correct.", "Processing Check-Out", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dResult == DialogResult.Yes)
            {
                //Display Confirmation Message
                MessageBox.Show("The selected reservation has been checked-out", "Check Out Processed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Resetting UI
                cboSelectRes.SelectedIndex = -1;
            }
            else if(dResult == DialogResult.No)
            {
                //Resetting UI
                cboSelectRes.SelectedIndex = -1;
            }
        }
    }
}
