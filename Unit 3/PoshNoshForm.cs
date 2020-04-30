using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CO453_WindowsFormLiam.Unit_3
{
    /// <summary>
    /// This class was used for the posh nosh form in task 3.3 (PoshNoshForm)
    /// </summary>
    public partial class PoshNoshForm : Form
    {
        double totalCost, starterCost, mainCost, dessertCost;

        /// <summary>
        /// This method was used for the starter list box and will add the price of whatever is selected to the overall price
        /// </summary>
        private void StarterListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (StarterListBox.Text)
            {
                case "Soup of the Day": starterCost = 6.50; break;
                case "Chilli Fish Cakes": starterCost = 5.00; break;
                case "Garlic Bread w/ Cheese": starterCost = 4.00; break;
                case "Calamari": starterCost = 7.25; break;
                case "Fried Chicken w/ BBQ Dip": starterCost = 5.50; break;
                case "Prosciutto": starterCost = 8.25; break;
                case "Sweet Potato Fries": starterCost = 7.25; break;
            }
            totalCost = starterCost + mainCost + dessertCost;
            TotalCostLabel.Text = "£" + totalCost.ToString("0.00");
        }

        /// <summary>
        /// This method was used for the dessert combo box and will add the price of whatever is selected to the overall price
        /// </summary>
        private void DessertComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (DessertComboBox.Text)
            {
                case "Cheesecake": dessertCost = 6.50; break;
                case "Hot Chocolate Cake": dessertCost = 7.50; break;
                case "Ice Cream Sundae": dessertCost = 7.00; break;
                case "Chocolate Fudge Brownie": dessertCost = 8.25; break;
            }
            totalCost = starterCost + mainCost + dessertCost;
            TotalCostLabel.Text = "£" + totalCost.ToString("0.00");
        }

        /// <summary>
        /// Constructor used for the posh nosh form
        /// </summary>
        public PoshNoshForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method was used for the quit button and will exit the application when pressed
        /// </summary>
        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This method was used for the main list box and will add the price of whatever is selected to the overall price
        /// </summary>
        private void MainListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (MainListBox.Text)
            {
                case "Steak and Chips": mainCost = 12.50; break;
                case "Fish and Chips": mainCost = 7.50; break;
                case "Vegetable Curry": mainCost = 8.00; break;
                case "Chicken Lasagne": mainCost = 7.25; break;
            }
            totalCost = starterCost + mainCost + dessertCost;
            TotalCostLabel.Text = "£" + totalCost.ToString("0.00");
        }
    }
}
