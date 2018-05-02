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
            //Validate Data
            if (!Validation.checkEmptyCombo(cboType))
                return;

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
                //Loads the availible Rooms from the Rooms File
                for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                {
                    cboRoomNo.Items.Add(ds.Tables[0].Rows[i][0].ToString() + " " + ds.Tables[0].Rows[i][1].ToString());
                }
                   
                //Sets the Arrival and Departure Date for the Reservation
                newRes.setArrivalDate(dtpArrDate.Value.ToString("yyyy-MM-dd"));
                newRes.setDeptDate(dtpDeptDate.Value.ToString("yyyy-MM-dd"));

                //Disabling the user from changing information after selecting the button
                dtpArrDate.Enabled = false;
                dtpDeptDate.Enabled = false;
                cboType.Enabled = false;
                btnSelectRes.Enabled = false;
                
                //Showing Next Step
                Size = new Size(350, 500);
                grpSelectRoom.Show();
            }
        }

        private void btnSelectRoom_Click(object sender, EventArgs e)
        {
            //Validate Data
            if (!Validation.checkEmptyCombo(cboRoomNo))
                return;

            //Sets the RoomNo and Cost for the Reservation
            newRes.setRoomNO(Convert.ToUInt16(cboRoomNo.Text.Substring(0, 3)));
            newRes.setCost((Convert.ToDateTime(dtpDeptDate.Text) - Convert.ToDateTime(dtpArrDate.Text)).TotalDays * Reservation.findRate(newRes.getRoomNo()));

            cboRoomNo.Enabled = false;
            btnSelectRoom.Enabled = false;
            //Show Next Step
            Size = new Size(600, 500);
            grpCustomer.Show();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //Validate Data
            if (!Validation.checkNonNumeric(txtFname))
                return;

            if (!Validation.checkNonNumeric(txtSname))
                return;

            if (!Validation.checkNonNumeric(txtStreet))
                return;

            if (!Validation.checkNonNumeric(txtTown))
                return;

            if (!Validation.checkNonNumeric(txtCounty))
                return;

            if (!Validation.checkNumeric(txtTelNo))
                return;

            if (!Validation.checkNumeric(txtCardNo))
                return;

            if (!Validation.checkNonNumeric(txtCardName))
                return;

            if (!Validation.checkEmptyText(txtFname))
                return;

            if (!Validation.checkEmptyText(txtSname))
                return;

            if (!Validation.checkEmptyText(txtStreet))
                return;

            if (!Validation.checkEmptyText(txtTown))
                return;

            if (!Validation.checkEmptyText(txtCounty))
                return;

            if (!Validation.checkEmptyText(txtTelNo))
                return;

            if (!Validation.checkEmptyText(txtCardNo))
                return;

            if (!Validation.checkEmptyText(txtCardName))
                return;

            //Sets the Customer Details
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

            //Saves the Customer Detail to the Customer File
            newCust.addCustomer();

            //Sets the ResNo and CustID for the Reservation
            newRes.setResNo(Reservation.nextRes());
            newRes.setCustID(newCust.getCustID());

            //Saves data to the Reservation File
            newRes.addReservation();

            //Display Confirmation
            MessageBox.Show("You have successfully added a reservation for " + txtFname.Text + " " + txtSname.Text, "Reservation added", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

            cboRoomNo.Enabled = true;
            btnSelectRoom.Enabled = true;
            grpSelectRoom.Hide();

            Size = new Size(350, 330);

            dtpArrDate.Enabled = true;
            dtpDeptDate.Enabled = true;
            cboType.Enabled = true;
            btnSelectRes.Enabled = true;
            grpSelectRes.Show();
            
        }

        private void dtpArrDate_ValueChanged(object sender, EventArgs e)
        {
            //Sets the second dtp to one day after the first dtp, ensuring the user cannot book the Arrival Date and Departure Date on the same Day
            dtpDeptDate.MinDate = dtpArrDate.Value.AddDays(1);
        }

        private void frmMakeReservation_Load(object sender, EventArgs e)
        {
            dtpArrDate.MinDate = DateTime.Today;
            //Loads All the Types from the Rates File
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
