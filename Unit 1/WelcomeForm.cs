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
    /// This class was used for task 1.1, 1.2 and 1.3 (WelcomeForm)
    /// </summary>
    public partial class WelcomeForm : Form
    {
        /// <summary>
        /// Contsructor used for the welcome form
        /// </summary>
        public WelcomeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method was used for the quit button of the form which will close the form when pressed
        /// </summary>
        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This method was used for the first show button that shows a different message and will change the colours of the labels
        /// </summary>
        private void ShowButton1_Click(object sender, EventArgs e)
        {
            BragLabel.Text = "Supa Dupa Computer\n Selling for £339";
            BragLabel.BackColor = Color.Aquamarine;
            BragLabel.ForeColor = Color.YellowGreen;
            GreetingLabel.BackColor = Color.Aquamarine;
            GreetingLabel.ForeColor = Color.YellowGreen;
        }

        /// <summary>
        /// This method was used for the second show button that also shows a different message and will change the colours of the labels
        /// </summary>
        private void ShowButton2_Click(object sender, EventArgs e)
        {
            BragLabel.Text = "C#.NET for Dumbos\n A real bargain at £29.99";
            BragLabel.BackColor = Color.Coral;
            BragLabel.ForeColor = Color.AntiqueWhite;
            GreetingLabel.BackColor = Color.Coral;
            GreetingLabel.ForeColor = Color.AntiqueWhite;
        }
    }
}
