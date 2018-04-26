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
    public partial class frmUpdateRoom : Form
    {
        frmMainMenu parent;
        Room updRoom = new Room();

        public frmUpdateRoom updateRoom;
        public frmUpdateRoom()
        {
            InitializeComponent();
        }
        public frmUpdateRoom(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnSelectRoom_Click(object sender, EventArgs e)
        {
            if (cboSelectRoom.Text.Equals(""))
            {
                MessageBox.Show("You did not select a Room.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboSelectRoom.Focus();
                return;
            }

            grpSelectRoom.Hide();
            grpUpdateRoom.Show();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void btnConfirmUpdate_Click(object sender, EventArgs e)
        {
            //Validate Data
            if (!Validation.checkEmptyText(txtDescription))
                return;

            if (!Validation.checkNonNumeric(txtDescription))
                return;


            //Sets the Room Details
            updRoom.setRoomNo(Convert.ToInt16(txtSelectedRoomNo.Text));
            updRoom.setDescription(txtDescription.Text);
            updRoom.setType(cboSelectType.Text.Substring(0,2));
            if (updRoom.getStatus() == "C")
                updRoom.setStatus("U");

            //Updates the Room Details in the Room File
            updRoom.updateRoom();

            MessageBox.Show("You have successfully updated Room " + txtSelectedRoomNo.Text, "Room Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            cboSelectRoom.SelectedIndex = -1;
            Size = new Size(400, 225);
            grpUpdateRoom.Hide();
            grpSelectRoom.Show();
        }

        private void frmUpdateRoom_Load(object sender, EventArgs e)
        {
            //Loads all Rooms from the Rooms File
            DataSet ds = new DataSet();
            cboSelectRoom.Items.Clear();
            ds = Room.getAllRooms(ds);

            for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
            {
                cboSelectRoom.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void cboSelectRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSelectRoom.SelectedIndex == -1)
                return;

            //Loads the Rooms Details in the Text Boxes and displays them
            Room updRoom = new Room();
            updRoom.loadRoom(cboSelectRoom.Text);

            if (updRoom.getRoomNo().Equals(""))
            {
                MessageBox.Show("No Details Found for this Room. Please select another.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboSelectRoom.Focus();
                return;
            }

            txtSelectedRoomNo.Text = updRoom.getRoomNo().ToString();
            txtDescription.Text = updRoom.getDescription();

            DataSet ds = new DataSet();
            cboSelectType.Items.Clear();
            ds = Rates.getAllRates(ds);

            for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
            {
                cboSelectType.Items.Add(ds.Tables[0].Rows[i][0].ToString() + " " + ds.Tables[0].Rows[i][1].ToString());
            }

            setType(updRoom.getType());

            Size = new Size(400, 450);
            grpUpdateRoom.Visible = true;
        }

        public void setType(String Type)
        {
            //Loads a list of all Room Types from the Rates File
            cboSelectType.SelectedIndex = 0;

            while (!cboSelectType.Text.Substring(0, 2).Equals(Type))
            {
                cboSelectType.SelectedIndex++;
            }
        }
    }
}
