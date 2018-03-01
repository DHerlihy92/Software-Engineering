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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void addRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmAddRate frmNextForm = new frmAddRate(this);
            frmNextForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuUpdRate_Click(object sender, EventArgs e)
        {
            this.Hide();

            UpdateRate frmNextForm = new UpdateRate(this);
            frmNextForm.Show();
        }

        private void mnuAddRoom_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmAddRoom frmNextForm = new frmAddRoom(this);
            frmNextForm.Show();
        }

        private void mnuCloseRoom_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRoomClose frmNextForm = new frmRoomClose(this);
            frmNextForm.Show();
        }

        private void mnuUpdRoom_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateRoom frmNextForm = new frmUpdateRoom(this);
            frmNextForm.Show();
        }

        private void makeReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMakeReservation frmNextForm = new frmMakeReservation(this);
            frmNextForm.Show();
        }

        private void cancelReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCancelReservation frmNextForm = new frmCancelReservation(this);
            frmNextForm.Show();
        }

        private void mnuProcessNS_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProcessNoShows frmNextForm = new frmProcessNoShows(this);
            frmNextForm.Show();
        }

        private void mnuCheckIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCheckIn frmNextForm = new frmCheckIn(this);
            frmNextForm.Show();
        }

        private void mnuCheckOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCheckOut frmNextForm = new frmCheckOut(this);
            frmNextForm.Show();
        }

        private void mnuRoomAnalysis_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTypeAnalysis frmNextForm = new frmTypeAnalysis(this);
            frmNextForm.Show();
        }

        private void mnuYearAnalysis_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmYearlyAnalysis frmNextForm = new frmYearlyAnalysis(this);
            frmNextForm.Show();
        }
    }
}
