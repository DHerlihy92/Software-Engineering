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
    public partial class frmCheckIn : Form
    {
        frmMainMenu parent;

        public frmCheckIn(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }
        public frmCheckIn()
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
            DialogResult dResult =MessageBox.Show("Are you sure this reservation is correct.", "Processing Check-In", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dResult == DialogResult.Yes)
            {
                

                Payment newPayment = new Payment();

                newPayment.setPayID(Payment.nextPayID());
                newPayment.setPayDate(DateTime.Now.ToString("yyyy-MM-dd"));
                newPayment.setResNo(Convert.ToInt16(cboSelectRes.Text.Substring(0, 4)));

                newPayment.addPayment();
                
                //Display Confirmation Message
                MessageBox.Show("The selected reservation has been checked-in and the customer has been charged.", "Check In Processed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Reservation.changeResStatus(Convert.ToInt16(cboSelectRes.Text.Substring(0, 4)), "CI");

                //Resetting UI
                cboSelectRes.SelectedIndex = -1;
            }
            else if (dResult == DialogResult.No)
            {
                //Resetting UI
                cboSelectRes.SelectedIndex = -1;
            }
        }

        private void frmCheckIn_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            cboSelectRes.Items.Clear();
            ds = Reservation.getCheckIns(ds, DateTime.Now.ToString("yyyy-MM-dd"));

            if (ds.Tables["ss"].Rows.Count == 0)
            {
                MessageBox.Show("There are rooms availible to be checked-in", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
