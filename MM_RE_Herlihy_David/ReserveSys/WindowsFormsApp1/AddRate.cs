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
        }


        private void btnAddRate_Click(object sender, EventArgs e)
        {
            // validate data
            if(!Validation.checkEmptyText(txtRateType))
                return;

            if(!Validation.checkNonNumeric(txtRateType))
                return;

            if (!Validation.checkEmptyText(txtRateDesc))
                return;

            if (!Validation.checkNonNumeric(txtRateDesc))
                return;

            if (!Validation.checkEmptyText(txtRateAmount))
                return;

            if (!Validation.checkNumeric(txtRateAmount))
                return;

            if (!Rates.rateExists(txtRateType.Text))
            {
                MessageBox.Show("This rate has already been entered in the database. Please enter a new rate.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRateType.Focus();
                txtRateType.Text = "";
                txtRateDesc.Text = "";
                txtRateAmount.Text = "";
                return;
            }
            
            //Sets the details of new rate from form
            Rates newRate = new Rates();

            newRate.setRoom_Type(txtRateType.Text);
            newRate.setDescription(txtRateDesc.Text);
            newRate.setRate(Convert.ToDecimal(txtRateAmount.Text));

            //Saves details in the Rates File
            newRate.addRate();

            //Display confirmation message
            MessageBox.Show("You have added a new rate for '" + txtRateDesc.Text +"'.", "Rate Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}
