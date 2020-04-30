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
    /// This class was used for the currency converter in task 3.1 (CurrencyConverterForm)
    /// </summary>
    public partial class CurrencyConverterForm : Form
    {
        /// <summary>
        /// Constructor for the currency converter form
        /// </summary>
        public CurrencyConverterForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method was used for the dollar radio button and will convert pounds to dollars when checked
        /// </summary>
        private void DollarsButton_CheckedChanged(object sender, EventArgs e)
        {
            double amount;
            amount = Convert.ToDouble(UKMoneyTextBox.Text) * 1.8;
            ConvertedMoneyLabel.Text = amount.ToString() + " Dollars";
        }

        /// <summary>
        /// This method was used for the euro radio button and will convert pounds to euros when checked
        /// </summary>
        private void EurosButton_CheckedChanged(object sender, EventArgs e)
        {
            double amount;
            amount = Convert.ToDouble(UKMoneyTextBox.Text) * 1.4;
            ConvertedMoneyLabel.Text = amount.ToString() + " Euros";
        }

        /// <summary>
        /// This method was used for the rupee radio button and will convert pounds to rupees when checked
        /// </summary>
        private void RupeesButton_CheckedChanged(object sender, EventArgs e)
        {
            double amount;
            amount = Convert.ToDouble(UKMoneyTextBox.Text) * 80;
            ConvertedMoneyLabel.Text = amount.ToString() + " Rupees";
        }

        /// <summary>
        /// This method was used for the quit button and will ask if the user wants to exit the application or not upon clicking it
        /// </summary>
        private void QuitButton_Click(object sender, EventArgs e)
        {
            DialogResult response;
            response = MessageBox.Show("Do you want to quit?", "Check",
            MessageBoxButtons.YesNo);
            if (response == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
