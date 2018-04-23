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
            float check;

            if (!Validation.checkEmptyText(txtDescription))
            {
                txtDescription.Focus();
                return;
            }

            if (!Validation.checkNonNumeric(txtDescription))
            {
                txtDescription.Focus();
                return;
            }

            if (!Validation.checkEmptyCombo(cboSelectRoom))
            {
                cboSelectRoom.Focus();
                return;
            }


            Room updRoom = new Room();

            updRoom.setRoomNo(Convert.ToInt16(txtSelectedRoomNo.Text));
            updRoom.setDescription(txtDescription.Text);
            updRoom.setType(cboSelectType.Text.Substring(0,2));
            updRoom.setStatus("U");

            updRoom.updateRoom();

            MessageBox.Show("You have successfully updated the room", "Room Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cboSelectRoom.SelectedIndex = -1;
            grpUpdateRoom.Hide();
            grpSelectRoom.Show();
        }

        private void frmUpdateRoom_Load(object sender, EventArgs e)
        {
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
            {
                return;
            }

            Room updRoom = new Room();
            updRoom.loadRoom(cboSelectRoom.Text);

            if (updRoom.getRoomNo().Equals(""))
            {
                MessageBox.Show("No Details Found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRoomNo.Focus();
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

            grpUpdateRoom.Visible = true;
        }

        public void setType(String Type)
        {
            cboSelectType.SelectedIndex = 0;

            while (!cboSelectType.Text.Substring(0, 2).Equals(Type))
            {
                cboSelectType.SelectedIndex++;
            }
        }
    }
}
