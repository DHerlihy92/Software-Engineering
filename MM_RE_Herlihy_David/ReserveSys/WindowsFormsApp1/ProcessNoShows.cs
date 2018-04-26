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
    public partial class frmProcessNoShows : Form
    {
        frmMainMenu parent;

        public frmProcessNoShows(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }
        public frmProcessNoShows()
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
            if (!Validation.checkEmptyCombo(cboSelectRes))
                return;

            //Display Yes/No dialog to confirm Reservation
            DialogResult dResult = MessageBox.Show("Are you sure this reservation is correct?", "Processing No-Show", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dResult == DialogResult.Yes)
            {
                //Sets the Payment Details
                Payment newPayment = new Payment();

                newPayment.setPayID(Payment.nextPayID());
                newPayment.setPayDate(DateTime.Now.ToString("yyyy-MM-dd"));
                newPayment.setResNo(Convert.ToInt16(cboSelectRes.Text.Substring(0, 4)));

                //Saves data to the Payments File
                newPayment.addPayment();

                //Display Confirmation Message
                MessageBox.Show("The selected reservation has been processed and the customer has been charged.", "No-Show Processed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Changes Reservation Status to No-Show
                Reservation.changeResStatus(Convert.ToInt16(cboSelectRes.Text.Substring(0, 4)), "NS");

                //Resetting UI
                cboSelectRes.SelectedIndex = -1;
            }

            else if(dResult == DialogResult.No)
            {
                MessageBox.Show("No changes have been made.", "No changes.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Resetting UI
                cboSelectRes.SelectedIndex = -1;
            }
        }

        private void frmProcessNoShows_Load(object sender, EventArgs e)
        {
            //Loads all Reservations where more than 24 hours has passed since the Arrival Date 
            DataSet ds = new DataSet();
            cboSelectRes.Items.Clear();
            ds = Reservation.getNoShows(ds);

            if (ds.Tables["ss"].Rows.Count == 0)
            {
                MessageBox.Show("There are no No-Shows", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboSelectRes.Focus();
            }
            else
            {
                for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                {
                    cboSelectRes.Items.Add(ds.Tables[0].Rows[i][0].ToString() + " " + ds.Tables[0].Rows[i][1].ToString());
                }
            }

        }
    }
}
