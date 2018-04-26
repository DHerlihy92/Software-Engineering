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
    class Validation
    {
        //Checks if a text box is empty
        public static Boolean checkEmptyText(TextBox txt)
        {
            Boolean check = true;

            if (txt.Text.Equals(""))
            {
                MessageBox.Show("This text box must be filled in.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt.Focus();
                txt.BackColor = Color.Beige;
                check = false;
            }
            return check;
        }

        //Checks if a combo box is empty
        public static Boolean checkEmptyCombo(ComboBox cbo)
        {
            Boolean check = true;

            if (cbo.Text.Equals(""))
            {
                MessageBox.Show("This field must be entered.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbo.BackColor = Color.Beige;
                check = false;
            }
            return check;
        }

        //Checks if the text in a text box is Text only
        public static Boolean checkNonNumeric(TextBox txt)
        {
            Boolean check = true;
            float numeric;

            if (float.TryParse(txt.Text, out numeric))
            {
                MessageBox.Show("This must not be a numeric value only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt.Focus();
                txt.BackColor = Color.Beige;
                check = false;
            }
            return check;
        }

        //Checks if the text in a text box is Numeric only
        public static Boolean checkNumeric(TextBox txt)
        {
            Boolean check = true;
            float numeric;

            if (!float.TryParse(txt.Text, out numeric))
            {
                MessageBox.Show("This must be a numeric value only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt.Focus();
                txt.BackColor = Color.Beige;
                check = false;
            }
            return check;
        }

    }
}
