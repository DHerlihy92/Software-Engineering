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
    public partial class frmAddRate : Form
    {
        frmMainMenu parent;

        public frmAddRate addRate;
        public frmAddRate()
        {
            InitializeComponent();
        }

        public frmAddRate(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
            txtRateType.Focus();
        }


        private void btnAddRate_Click(object sender, EventArgs e)
        {
            float check;
            // validate data
            if (txtRateType.Text.Equals(""))
            {
                MessageBox.Show("You did not enter a Type for the Rate.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRateType.Focus();
                return;
            }
            if (float.TryParse(txtRateType.Text, out check))
            {
                MessageBox.Show("A type must not be a numeric value only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRateType.Focus();
                return;
            }

            if (txtRateDesc.Text.Equals(""))
            {
                MessageBox.Show("You did not select a Description for the Rate.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRateDesc.Focus();
                return;
            }

            if (float.TryParse(txtRateDesc.Text, out check))
            {
                MessageBox.Show("A description must not be a numeric value only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRateDesc.Focus();
                return;
            }

            if (txtRateAmount.Text.Equals(""))
            {
                MessageBox.Show("You did not select an Amount for the Rate.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRateAmount.Focus();
                return;
            }

            if (!float.TryParse(txtRateAmount.Text, out check))
            {
                MessageBox.Show("Please enter a numeric value only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRateAmount.Focus();
                return;
            }

            if(float.Parse(txtRateAmount.Text) > 999)
            {
                MessageBox.Show("A rate cannot exceed 999.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRateAmount.Focus();
                return;
            }

            if (Rates.rateExists(txtRateType.Text))
            {
                MessageBox.Show("This rate has already been entered in the database. Please enter a new rate.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRateType.Focus();
                txtRateType.Text = "";
                txtRateDesc.Text = "";
                txtRateAmount.Text = "";
                return;
            }
            //Create rate object
            Rates newRate = new Rates();

            newRate.setRoom_Type(txtRateType.Text);
            newRate.setDescription(txtRateDesc.Text);
            newRate.setRate(Convert.ToDecimal(txtRateAmount.Text));

            //Insert into rates

            newRate.addRate();

            //Display confirmation message
            MessageBox.Show("You have added a new rate.", "Rate Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            txtRateType.Text = "";
            txtRateDesc.Text = "";
            txtRateAmount.Text = "";
            txtRateType.Focus();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void frmAddRate_Load(object sender, EventArgs e)
        {
            txtRateType.Focus();
        }

    }
}
