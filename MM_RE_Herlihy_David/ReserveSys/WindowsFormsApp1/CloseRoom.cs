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
    public partial class frmRoomClose : Form
    {
        frmMainMenu parent;

        public frmRoomClose roomClose;
        public frmRoomClose()
        {
            InitializeComponent();
        }

        public frmRoomClose(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnCloseRoom_Click(object sender, EventArgs e)
        {
            // validate data
            if (!Validation.checkEmptyCombo(cboCloseRoom))
            {
                cboCloseRoom.Focus();
                return;
            }


            //Display confirmation message
            DialogResult dResult = MessageBox.Show("Are you sure you would like to close this room?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dResult == DialogResult.Yes)
            {
                //Checks if the Room has Reservations
                if (Room.checkFreeRooms(cboCloseRoom.Text))
                {
                    Room.changeRoomStatus(Convert.ToInt16(cboCloseRoom.Text), "C");

                    MessageBox.Show("Room " + cboCloseRoom.Text + " has been closed.", "Room Closed.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Reset UI
                    cboCloseRoom.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Room " + cboCloseRoom.Text + " has reservations booked. Unable to close.", "Unable To Close.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Reset UI
                    cboCloseRoom.SelectedIndex = -1;
                }
            }
            else if(dResult == DialogResult.No)

                MessageBox.Show("No changes have been made.", "No changes.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Reset UI
            cboCloseRoom.SelectedIndex = -1;
            }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void frmRoomClose_Load(object sender, EventArgs e)
        {
            //Loads a list of all Rooms
            DataSet ds = new DataSet();
            cboCloseRoom.Items.Clear();
            //add check if room has any reservations
            ds = Room.getAllRooms(ds);

            for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
            {
                cboCloseRoom.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }
    }
}
