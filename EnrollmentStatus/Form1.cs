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
* Andrew Terwilliger 1/23/2020     *
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

        private void btnWhatStatus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCredits.Text, out double credits)) {
                if (credits > 24)
                    MessageBox.Show("Invalid number of hours entered.", "Number Overload");
                else if (credits >= 12)
                    lblStatus.Text = "You are Full-Time.";
                else if (credits >= 6)
                    lblStatus.Text = "You are Part-Time.";
                else if (credits >= 0)
                    lblStatus.Text = "You are less than Part-Time.";
            } else
            {
                MessageBox.Show("Please enter only numbers.", "Error");
            }
        }
    }
}
