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

namespace LoopTests
{
    public partial class Form1 : Form
    {
        // Assigning global value for "forLoop" function, enabling it to be set from the trackbar.
        int forLoopValue = 1;

        public Form1()
        {
            InitializeComponent();
        }

        // WhileLoop function, basic function demonstrating the useage of while loops checking if the MessageBox result is Yes.
        private void btnWhile_Click(object sender, EventArgs e)
        {
            DialogResult selected = MessageBox.Show("Do you want to see another MessageBox?", "While", MessageBoxButtons.YesNo);

            while (selected == DialogResult.Yes)
            {
                selected = MessageBox.Show("Here's another MessageBox, would you like another?", "While", MessageBoxButtons.YesNo);
            }
        }

        // DoWhileLoop function, basic function looping "Do - While", doing function while the MessageBox result is Yes.
        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            // Initializing the dialog result as the selected variable.
            DialogResult selected;

            do
            {
                selected = MessageBox.Show("Do you want another MessageBox?", "Do While", MessageBoxButtons.YesNo);
            } while (selected == DialogResult.Yes);
        }

        // ForLoop function, basic function looping "for" a specific value - using the class value "forLoopValue" as how many times to loop.
        private void btnForLoop_Click(object sender, EventArgs e)
        {
            for (int m = 1; m < forLoopValue; m++)
            {
                MessageBox.Show("This is MessageBox " + m); // Using the in-line variable "m" to signify what loop this is on.
            }
        }

        // Trackbar scrolling function, changing the value of the class "forLoopValue" by what the current value of the trackbar is.
        private void trkLoops_Scroll(object sender, EventArgs e)
        {
            forLoopValue = trkLoops.Value;
            lblForLoop.Text = forLoopValue.ToString();
        }
    }
}
