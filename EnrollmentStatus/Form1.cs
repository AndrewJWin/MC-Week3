using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**********************************\
*                                  *
* Andrew Terwilliger 2/1/2020     *
* Minneapolis College              *
* ITEC 2505-60 C# Programming      *
*                                  *
\**********************************/

namespace EnrollmentStatus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // "Whats My Status" button function, checking the value of "txtCredits" against multiple if statements to validate hour-status.
        private void btnWhatStatus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCredits.Text, out double credits)) {
                // Most colleges tend to limit the hours to 18, however - Students "can" request more than the limit. Though ill-advised.
                if (credits > 24)
                    MessageBox.Show("Invalid number of hours entered.", "Number Overload");
                else if (credits >= 12)
                    lblStatus.Text = "You are Full-Time.";
                else if (credits >= 6)
                    lblStatus.Text = "You are Part-Time.";
                else if (credits >= 0) // You can't go negative, so limiting any value above 0 and less than 6.
                    lblStatus.Text = "You are less than Part-Time.";
            } else
            {
                // Elsewise, if the value is less than 0, or not even a number - Respond accordingly.s
                MessageBox.Show("Please enter only numbers.", "Error");
            }
        }
    }
}
