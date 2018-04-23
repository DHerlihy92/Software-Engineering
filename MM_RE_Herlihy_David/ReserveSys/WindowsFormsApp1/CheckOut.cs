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
            if (!Validation.checkEmptyCombo(cboSelectRes))
            {
                cboSelectRes.Focus();
                return;
            }


            //Display Yes/No dialog to confirm Reservation
            DialogResult dResult = MessageBox.Show("Are you sure this reservation is correct.", "Processing Check-Out", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dResult == DialogResult.Yes)
            {
                //Display Confirmation Message
                MessageBox.Show("The selected reservation has been checked-out", "Check Out Processed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Reservation.changeResStatus(Convert.ToInt16(cboSelectRes.Text.Substring(0, 4)), "CO");

                //Resetting UI
                cboSelectRes.SelectedIndex = -1;
            }
            else if(dResult == DialogResult.No)
            {
                //Resetting UI
                cboSelectRes.SelectedIndex = -1;
            }
        }

        private void frmCheckOut_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            cboSelectRes.Items.Clear();
            ds = Reservation.getCheckOuts(ds, DateTime.Now.ToString("yyyy-MM-dd"));

            if (ds.Tables["ss"].Rows.Count == 0)
            {
                MessageBox.Show("There are no Check-Outs", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
