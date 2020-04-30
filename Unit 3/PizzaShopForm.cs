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
    /// This class was used for the pizza shop form in task3.2 (PizzaShopForm)
    /// </summary>
    public partial class PizzaShopForm : Form
    {
        double pizzaPrice;

        /// <summary>
        /// Constructor used for the pizza shop form
        /// </summary>
        public PizzaShopForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method was used for the quit button and will exit the application
        /// </summary>
        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This method was used for the large radio button and will set the price to £10
        /// </summary>
        private void LargeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pizzaPrice = 10;
            pizzaPrice.ToString();
            PizzaCostLabel.Text = "£" + pizzaPrice;
        }

        /// <summary>
        /// This method was used for the medium radio button and will set the price to £8
        /// </summary>
        private void MediumRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pizzaPrice = 8;
            pizzaPrice.ToString();
            PizzaCostLabel.Text = "£" + pizzaPrice;
        }

        /// <summary>
        /// This method was used for the small radio button and will set the price to £5
        /// </summary>
        private void SmallRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pizzaPrice = 5;
            pizzaPrice.ToString();
            PizzaCostLabel.Text = "£" + pizzaPrice;
        }

        /// <summary>
        /// This method was used for check box 1 and will add £2.50 to the overall price and display it
        /// </summary>
        private void CB1_CheckedChanged(object sender, EventArgs e)
        {
            pizzaPrice = pizzaPrice + 2.5;
            pizzaPrice.ToString();
            PizzaCostLabel.Text = "£" + pizzaPrice;
        }

        /// <summary>
        /// This method was used for check box 2 and will add £2.50 to the overall price and display it
        /// </summary>
        private void CB2_CheckedChanged(object sender, EventArgs e)
        {
            pizzaPrice = pizzaPrice + 2.5;
            pizzaPrice.ToString();
            PizzaCostLabel.Text = "£" + pizzaPrice;
        }

        /// <summary>
        /// This method was used for check box 3 and will add £2.50 to the overall price and display it
        /// </summary>
        private void CB3_CheckedChanged(object sender, EventArgs e)
        {
            pizzaPrice = pizzaPrice + 2.5;
            pizzaPrice.ToString();
            PizzaCostLabel.Text = "£" + pizzaPrice;
        }

        /// <summary>
        /// This method was used for check box 4 and will add £2.50 to the overall price and display it
        /// </summary>
        private void CB4_CheckedChanged(object sender, EventArgs e)
        {
            pizzaPrice = pizzaPrice + 2.5;
            pizzaPrice.ToString();
            PizzaCostLabel.Text = "£" + pizzaPrice;
        }
    }
}
