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

        // "trkCredits" Scroll function, evalutates the status of a student based on how many credits they set the trackbar to.
        private void trkCredits_Scroll(object sender, EventArgs e)
        {
            int credits = trkCredits.Value;

            lblCredits.Text = credits.ToString();

            if (credits >= 12)
                lblStatus.Text = "You are full-time";
            else if (credits >= 6)
                lblStatus.Text = "You are part-time";
            else if (credits >= 0)
                lblStatus.Text = "You are less than part-time.";

        }
    }
}
