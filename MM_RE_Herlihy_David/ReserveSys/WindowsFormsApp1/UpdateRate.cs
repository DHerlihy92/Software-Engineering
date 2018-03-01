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
    public partial class UpdateRate : Form
    {
        frmMainMenu parent;

        public UpdateRate updateRate;

        public UpdateRate()
        {
            InitializeComponent();
        }

        public UpdateRate(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void UpdateRate_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            cboSelectRate.Items.Clear();
            ds = Rates.getAllRates(ds);

            for(int i = 0; i<ds.Tables["ss"].Rows.Count; i++)
            {
                cboSelectRate.Items.Add(ds.Tables[0].Rows[i][0].ToString() + " " + ds.Tables[0].Rows[i][1].ToString());
            }

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void btnSelectRate_Click(object sender, EventArgs e)
        {
            if (cboSelectRate.Text.Equals(""))
            {
                MessageBox.Show("You did not select a Rate.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboSelectRate.Focus();
                return;
            }

            grpSelectRate.Hide();
            grpUpdateRate.Show();

        }

        private void btnConfirmUpdate_Click(object sender, EventArgs e)
        {
            float check;
            if (txtUpdatedAmount.Text.Equals(""))
            {
                MessageBox.Show("You did not enter an Amount.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUpdatedAmount.Focus();
                return;
            }

            if (!float.TryParse(txtUpdatedAmount.Text, out check))
            {
                MessageBox.Show("Please enter a numeric value only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUpdatedAmount.Focus();
                return;
            }

            if (txtUpdatedDescription.Text.Equals(""))
            {
                MessageBox.Show("You did not enter a Description.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUpdatedDescription.Focus();
                return;
            }

            if (float.TryParse(txtUpdatedDescription.Text, out check))
            {
                MessageBox.Show("A Description must not be a numeric value only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUpdatedDescription.Focus();
                return;
            }

            if (float.Parse(txtUpdatedAmount.Text) > 999)
            {
                MessageBox.Show("A rate cannot exceed 999.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUpdatedAmount.Focus();
                return;
            }

            Rates myRate = new Rates();

            myRate.setRoom_Type(txtSelectedRateType.Text);
            myRate.setDescription(txtUpdatedDescription.Text);
            myRate.setRate(Convert.ToDecimal(txtUpdatedAmount.Text));

            myRate.updRate();

            //Display confirmation message
            MessageBox.Show("You have updated a rate.", "Rate Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI

            cboSelectRate.SelectedIndex = -1;
            grpUpdateRate.Hide();
            grpSelectRate.Show();

            DataSet ds = new DataSet();
            cboSelectRate.Items.Clear();
            ds = Rates.getAllRates(ds);

            for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
            {
                cboSelectRate.Items.Add(ds.Tables[0].Rows[i][0].ToString() + " " + ds.Tables[0].Rows[i][1].ToString());
            }
        }

        private void cboSelectRate_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(cboSelectRate.SelectedIndex == -1)
            {
                return;
            }

            Rates updRate = new Rates();
            updRate.loadRate(cboSelectRate.Text.Substring(0,2));
           
            if (updRate.getRoom_Type().Equals(""))
            {
                MessageBox.Show("No Details Found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSelectedRateType.Focus();
                return;
            }

            txtSelectedRateType.Text = updRate.getRoom_Type();
            txtUpdatedDescription.Text = updRate.getDescription();
            txtUpdatedAmount.Text = updRate.getRate().ToString();

            grpUpdateRate.Visible = true;
        }
    }
}
