using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopTests
{
    public partial class Form1 : Form
    {
        int forLoopValue = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            DialogResult selected = MessageBox.Show("Do you want to see another MessageBox?", "While", MessageBoxButtons.YesNo);

            while (selected == DialogResult.Yes)
            {
                selected = MessageBox.Show("Here's another MessageBox, would you like another?", "While", MessageBoxButtons.YesNo);
            }
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            DialogResult selected;

            do
            {
                selected = MessageBox.Show("Do you want another MessageBox?", "Do While", MessageBoxButtons.YesNo);
            } while (selected == DialogResult.Yes);
        }

        private void btnForLoop_Click(object sender, EventArgs e)
        {
            for (int m = 0; m < forLoopValue; m++)
            {
                MessageBox.Show("This is MessageBox " + m);
            }
        }

        private void trkLoops_Scroll(object sender, EventArgs e)
        {
            forLoopValue = trkLoops.Value;
            lblForLoop.Text = forLoopValue.ToString();
        }
    }
}
