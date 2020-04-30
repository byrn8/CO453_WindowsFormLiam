using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CO453_WindowsFormLiam
{
    /// <summary>
    /// This class was used for task 1.4 (DataEntryForm)
    /// </summary>
    public partial class DataEntryForm : Form
    {
        /// <summary>
        /// Constructor used for the data entry form
        /// </summary>
        public DataEntryForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method was used for the quit button of the form which will close the form
        /// </summary>
        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This method was used for the message button which displays a message based on the names and town that you input
        /// </summary>
        private void MessageButton_Click(object sender, EventArgs e)
        {
            MessageLabel.Text = "Hi " + FNameTextBox.Text + " " + SNameTextBox.Text + " from " + TownTextBox.Text + "\nHappy Programming";
        }

        /// <summary>
        /// This method for the clear button whicg will clear the message that is diplayed
        /// </summary>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            MessageLabel.Text = "";
        }

        /// <summary>
        /// This method was used for the upper case button which changes the message to upper case characters
        /// </summary>
        private void UpperButton_Click(object sender, EventArgs e)
        {
            //MessageLabel.Text = MessageLabel.Text.toUpper();
        }

        /// <summary>
        /// This method was used for the lower case button which changes the message to lower case characters
        /// </summary>
        private void LowerButton_Click(object sender, EventArgs e)
        {
            //MessageLabel.Text = MessageLabel.Text.toLower();
        }

        /// <summary>
        /// This method was used for the change message button that will add an addition message when clicked as well as changing the textbox and form colours
        /// </summary>
        private void ChangeMessageButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Fuchsia;
            FNameTextBox.BackColor = Color.LightBlue;
            SNameTextBox.BackColor = Color.LightBlue;

            MessageLabel.Text = MessageLabel.Text + "\nGet on with it " + FNameTextBox.Text;
        }
    }
}
