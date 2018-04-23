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
    public partial class frmMakeReservation : Form
    {
        frmMainMenu parent;
        Reservation newRes = new Reservation();

        public frmMakeReservation(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }
        public frmMakeReservation()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void btnSelectRes_Click(object sender, EventArgs e)
        {
            //Validate Date
            /*if(dtpArrDate.Text == dtpDeptDate.Text)
            {
                MessageBox.Show("Arrival Date and Departure Date must not be on the same day.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpArrDate.Focus();
                return;
            }*/

            if (!Validation.checkEmptyCombo(cboType))
            {
                cboType.Focus();
                return;
            }

            //Checks for availible rooms during selected dates and of the selected type
            DataSet ds = new DataSet();
            cboRoomNo.Items.Clear();
            ds = Reservation.getUnoccupiedRooms(ds, dtpArrDate.Value.ToString("yyyy-MM-dd"), dtpDeptDate.Value.ToString("yyyy-MM-dd"), cboType.Text.Substring(0, 2));

            //Checks if there are no rooms of the selected type availible during the selected dates and asks user to change their selection.
            if (ds.Tables["ss"].Rows.Count == 0)
            {
                MessageBox.Show("There is no availible rooms of this type during the period selected. Please select another Date/Type", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboType.Focus();
            }
            else
            {

                for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                {
                    cboRoomNo.Items.Add(ds.Tables[0].Rows[i][0].ToString() + " " + ds.Tables[0].Rows[i][1].ToString());
                }

                newRes.setArrivalDate(dtpArrDate.Value.ToString("yyyy-MM-dd"));
                newRes.setDeptDate(dtpDeptDate.Value.ToString("yyyy-MM-dd"));

                //Showing Next Step
                grpSelectRes.Hide();
                grpSelectRoom.Show();
            }
        }

        private void btnSelectRoom_Click(object sender, EventArgs e)
        {
            //Validate Data
            if (!Validation.checkEmptyCombo(cboRoomNo))
            {
                cboRoomNo.Focus();
                return;
            }


            newRes.setRoomNO(Convert.ToUInt16(cboRoomNo.Text.Substring(0, 3)));
            newRes.setCost((Convert.ToDateTime(dtpDeptDate.Text) - Convert.ToDateTime(dtpArrDate.Text)).TotalDays * Reservation.findRate(newRes.getRoomNo()));

            //Show Next Step
            grpSelectRoom.Hide();
            grpCustomer.Show();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //Validate Data
            float check;

            if (!Validation.checkNonNumeric(txtFname))
            {
                txtFname.Focus();
                return;
            }

            if (!Validation.checkNonNumeric(txtSname))
            {
                txtSname.Focus();
                return;
            }

            if (!Validation.checkNonNumeric(txtStreet))
            {
                txtStreet.Focus();
                return;
            }

            if (!Validation.checkNonNumeric(txtTown))
            {
                txtTown.Focus();
                return;
            }

            if (!Validation.checkNonNumeric(txtCounty))
            {
                txtCounty.Focus();
                return;
            }

            if (!Validation.checkNumeric(txtTelNo))
            {
                txtTelNo.Focus();
                return;
            }

            if (!Validation.checkNumeric(txtCardNo))
            {
                txtCardNo.Focus();
                return;
            }

            if (!Validation.checkNonNumeric(txtCardName))
            {
                txtCardName.Focus();
                return;
            }

            if (!Validation.checkEmptyText(txtFname))
            {
                txtFname.Focus();
                return;
            }

            if (!Validation.checkEmptyText(txtSname))
            {
                txtSname.Focus();
                return;
            }

            if (!Validation.checkEmptyText(txtStreet))
            {
                txtStreet.Focus();
                return;
            }

            if (!Validation.checkEmptyText(txtTown))
            {
                txtTown.Focus();
                return;
            }

            if (!Validation.checkEmptyText(txtCounty))
            {
                txtCounty.Focus();
                return;
            }

            if (!Validation.checkEmptyText(txtTelNo))
            {
                txtTelNo.Focus();
                return;
            }

            if (!Validation.checkEmptyText(txtCardNo))
            {
                txtCardNo.Focus();
                return;
            }

            if (!Validation.checkEmptyText(txtCardName))
            {
                txtCardName.Focus();
                return;
            }

            Customer newCust = new Customer();

            newCust.setCustID(Customer.nextCustomer());
            newCust.setFname(txtFname.Text);
            newCust.setSName(txtSname.Text);
            newCust.setStreet(txtStreet.Text);
            newCust.setTown(txtTown.Text);
            newCust.setCounty(txtCounty.Text);
            newCust.setTel_No(txtTelNo.Text);
            newCust.setCardNo(Convert.ToInt16(txtCardNo.Text));
            newCust.setCardName(txtCardName.Text);

            //Saves data to the Customer File
            newCust.addCustomer();

            newRes.setResNo(Reservation.nextRes());
            newRes.setCustID(newCust.getCustID());

            //Saves data to the Reservation File
            newRes.addReservation();

            //Display Confirmation
            MessageBox.Show("You have successfully added a reservation.", "Reservation added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Resetting UI
            dtpArrDate.ResetText();
            dtpDeptDate.ResetText();
            cboType.SelectedIndex = -1;

            cboRoomNo.SelectedIndex = -1;

            txtFname.Text = "";
            txtSname.Text = "";
            txtStreet.Text = "";
            txtTown.Text = "";
            txtCounty.Text = "";
            txtTelNo.Text = "";
            txtCardNo.Text = "";
            txtCardName.Text = "";

            //Resetting UI to first step
            grpCustomer.Hide();
            grpSelectRes.Show();
        }

        private void dtpArrDate_ValueChanged(object sender, EventArgs e)
        {
            dtpDeptDate.MinDate = dtpArrDate.Value.AddDays(1);
        }

        private void frmMakeReservation_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            cboType.Items.Clear();
            ds = Rates.getAllRates(ds);

            for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
            {
                cboType.Items.Add(ds.Tables[0].Rows[i][0].ToString() + " " + ds.Tables[0].Rows[i][1].ToString());
            }
        }

    }
}
