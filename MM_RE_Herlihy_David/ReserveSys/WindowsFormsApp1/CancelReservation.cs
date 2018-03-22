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
    public partial class frmCancelReservation : Form
    {
        frmMainMenu parent;

        public frmCancelReservation()
        {
            InitializeComponent();
        }

        public frmCancelReservation(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void btnSelectCust_Click(object sender, EventArgs e)
        {
            //Validate Data
            float check;

            if(float.TryParse(txtFname.Text, out check))
            {
                MessageBox.Show("This must not be a numeric value only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFname.Focus();
                return;
            }

            if (float.TryParse(txtSname.Text, out check))
            {
                MessageBox.Show("This must not be a numeric value only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSname.Focus();
                return;
            }

            if(txtFname.Text == "")
            {
                MessageBox.Show("This field must be entered.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFname.Focus();
                return;
            }

            if (txtSname.Text == "")
            {
                MessageBox.Show("This field must be entered.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSname.Focus();
                return;
            }

            DataSet ds = new DataSet();
            cboReservation.Items.Clear();
            ds = Reservation.getReservations(ds, txtFname.Text, txtSname.Text);

            if (ds.Tables["ss"].Rows.Count == 0)
            {
                MessageBox.Show("This customer has no active reservations.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFname.Focus();
            }

            else
            {
                for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                {
                    cboReservation.Items.Add(ds.Tables[0].Rows[i][0].ToString() + " " + ds.Tables[0].Rows[i][1].ToString());
                }

                //Showing next step
                grpSelectCust.Hide();
                grpSelectRes.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboReservation.Text.Equals(""))
            {
                MessageBox.Show("This field must be selected.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboReservation.Focus();
                return;
            }

            if (Convert.ToDateTime(cboReservation.Text.Substring(5,10)).DayOfYear > (DateTime.Now.DayOfYear+1))
            {
                //Display Yes/No dialog confirming selection
                DialogResult dResult = MessageBox.Show("Are you sure this is the correct reservation?", "Cancel Reservation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dResult == DialogResult.Yes)
                {
                    //Display confirmation message
                    MessageBox.Show("You have cancelled a Reservation.", "Reservation Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Reservation.changeResStatus(Convert.ToInt16(cboReservation.Text.Substring(0, 4)), "CL");

                    //Resetting UI
                    txtFname.Text = "";
                    txtSname.Text = "";
                    cboReservation.SelectedIndex = -1;

                    grpSelectRes.Hide();
                    grpSelectCust.Show();
                }

                else if(dResult == DialogResult.No)
                {
                    //Resetting UI
                    txtFname.Text = "";
                    txtSname.Text = "";
                    cboReservation.SelectedIndex = -1;

                    grpSelectRes.Hide();
                    grpSelectCust.Show();
                }
            }

            
        }
    }
}
