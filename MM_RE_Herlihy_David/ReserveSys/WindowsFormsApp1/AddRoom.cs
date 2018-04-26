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
    public partial class frmAddRoom : Form
    {
        frmMainMenu parent;
        public frmAddRoom addRoom;
        public frmAddRoom()
        {
            InitializeComponent();
        }
        public frmAddRoom(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnAddRooms_Click(object sender, EventArgs e)
        {
            // validate data
            if (!Validation.checkEmptyCombo(cboRoomType))
                return;

            if (!Validation.checkNonNumeric(txtDescription))
                return;

            if (!Validation.checkEmptyText(txtDescription))
                return;

            //Sets the Room Details from the form
            Room nextRoom = new Room();
            nextRoom.setRoomNo(Convert.ToInt16(txtRoomNo.Text));
            nextRoom.setType(cboRoomType.Text.Substring(0, 2));
            nextRoom.setDescription(txtDescription.Text);
            
            //Save data in Rooms File
            nextRoom.addRoom();

            //Display confirmation message
            MessageBox.Show("You successfully added Room " + txtRoomNo.Text, "Room Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            cboRoomType.SelectedIndex = -1;
            txtDescription.Text = "";
            txtRoomNo.Text = Room.nextRoomNo().ToString();
            cboRoomType.Focus();
        }

        private void frmAddRoom_Load(object sender, EventArgs e)
        {
            //Loads all Room Types from Rates File
            txtRoomNo.Text = Room.nextRoomNo().ToString();

            DataSet ds = new DataSet();
            cboRoomType.Items.Clear();
            ds = Rates.getAllRates(ds);

            for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
            {
                cboRoomType.Items.Add(ds.Tables[0].Rows[i][0].ToString() + " " + ds.Tables[0].Rows[i][1].ToString());
            }
        }


        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

    }
}
