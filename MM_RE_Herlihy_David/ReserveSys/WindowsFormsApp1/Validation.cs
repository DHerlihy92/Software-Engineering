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
        public static Boolean checkEmpty(TextBox txt)
        {
            Boolean check = true;

            if (txt.Text.Equals(""))
            {
                MessageBox.Show("You did not enter a Type for the Rate.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                check = false;
            }
            return check;
        }

        public static Boolean checkNonNumeric(TextBox txt)
        {
            Boolean check = true;
            float numeric;

            if (float.TryParse(txt.Text, out numeric))
            {
                MessageBox.Show("This must not be a numeric value only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                check = false;
            }
            return check;
        }

        public static Boolean checkNumeric(TextBox txt)
        {
            Boolean check = true;
            float numeric;

            if (!float.TryParse(txt.Text, out numeric))
            {
                MessageBox.Show("This must be a numeric value only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                check = false;
            }
            return check;
        }

    }
}
