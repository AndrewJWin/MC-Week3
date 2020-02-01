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
* Andrew Terwilliger 2/1/2020      *
* Minneapolis College              *
* ITEC 2505-60 C# Programming      *
*                                  *
\**********************************/

namespace PhotoOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Form loading function, adding possible values to the "cbxSize" ComboBox - Ranging from Small to Extra Large.
        private void Form1_Load(object sender, EventArgs e)
        {
            cbxSize.Items.Add("Small");
            cbxSize.Items.Add("Medium");
            cbxSize.Items.Add("Large");
            cbxSize.Items.Add("Extra Large");

            // This sets the selected item in the box to the "first" item. In C# lists start at 0, not 1.
            cbxSize.SelectedIndex = 0;
        }

        // "Calculate" button function, calculates the price of the final total - Taking into account the quantity and size of the photo.
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Validating the actual quantity textbox value, if it cannot parse into an integer - throw an error.
            if (!Int32.TryParse(txtQuantity.Text, out int quantity))
            {
                // Simple error response, but with a return to stop calculation.
                MessageBox.Show("Invalid Quantity, must be a number.", "Error");
                return;
            }

            // If the quantity isn't greater than 1, they're not buying anything - Therefore we can't charge them with anything - Throw error.
            if (quantity < 1)
            {
                // Simple error message, but with a return to stop calculation.
                MessageBox.Show("Invalid Quantity, must be greater than 0.", "Error");
                return;
            }

            // Setting "size" as a string variable with the SelectedItem in the ComboBox.
            string size = cbxSize.SelectedItem.ToString();
            // Placehold the price as a double numerical variable.
            double price;

            // Using a switch-case function to set price and safely breaking the calculation if a size is not priced.
            switch (size)
            {
                case "Small":
                    price = 0.20;
                    break;

                case "Medium":
                    price = 0.30;
                    break;

                case "Large":
                    price = 0.40;
                    break;

                case "Extra Large":
                    price = 0.50;
                    break;

                // Default case in the event that the size is not listed above.
                default:
                    MessageBox.Show("Unknown Size");
                    return;
            }

            // Finalizing the price, and setting the txtPrice as currency string based on the final total.
            double total = price * quantity;
            txtPrice.Text = total.ToString("c");
        }
    }
}
