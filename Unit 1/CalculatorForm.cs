using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CO453_WindowsFormLiam.Unit1
{
    /// <summary>
    /// This class was used for task 1.5, 1.8 and 1.10 (CalculatorForm)
    /// </summary>
    public partial class CalculatorForm : Form
    {
        /// <summary>
        /// Constructor used for the calculator form
        /// </summary>
        public CalculatorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method was used for the add button which will add the two values that the user inputs
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            double n1, n2, answer;
            n1 = Convert.ToDouble(FirstNumTextBox.Text);
            n2 = Convert.ToDouble(SecNumTextBox.Text);
            answer = n1 + n2;
            ResultLabel2.Text = answer.ToString();
            this.BackColor = Color.Aquamarine;
        }

        /// <summary>
        /// This method was used for the subtract button which will subtract the two values that the user inputs
        /// </summary>
        private void SubtractButton_Click(object sender, EventArgs e)
        {
            double n1, n2, answer;
            n1 = Convert.ToDouble(FirstNumTextBox.Text);
            n2 = Convert.ToDouble(SecNumTextBox.Text);
            answer = n1 - n2;
            ResultLabel2.Text = answer.ToString();
            this.BackColor = Color.Coral;
        }

        /// <summary>
        /// This method was used for the multiply button which will multiply the two values that the user inputs
        /// </summary>
        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            double n1, n2, answer;
            n1 = Convert.ToDouble(FirstNumTextBox.Text);
            n2 = Convert.ToDouble(SecNumTextBox.Text);
            answer = n1 * n2;
            ResultLabel2.Text = answer.ToString();
            this.BackColor = Color.PapayaWhip;
        }

        /// <summary>
        /// This method was used for the divide button which will divide the two values that the user inputs
        /// </summary>
        private void DivideButton_Click(object sender, EventArgs e)
        {
            double n1, n2, answer;
            n1 = Convert.ToDouble(FirstNumTextBox.Text);
            n2 = Convert.ToDouble(SecNumTextBox.Text);
            
            if(n2 == 0)
            {
                ResultLabel2.Text = "You should NOT \ndivide by ZERO!";
            }
           
            else
            {
                answer = n1 / n2;
                ResultLabel2.Text = answer.ToString();
            }

            this.BackColor = Color.Thistle;
        }

        /// <summary>
        /// This method was used for the quit button of the form which will close the form
        /// </summary>
        private void QuitButton_Click(object sender, EventArgs e)
        {
            QuitForm SScreen = new QuitForm();
            SScreen.ShowDialog();
        }

        /// <summary>
        /// This method was used to call the splash screen used in task 1.6
        /// </summary>
        private void Calculator_Load(object sender, EventArgs e)
        {
            SplashForm SScreen = new SplashForm();
            SScreen.ShowDialog();
        }

        /// <summary>
        /// This method was used for the power button which multiplys the first number to the power of the second number
        /// </summary>
        private void PowerButton_Click(object sender, EventArgs e)
        {
            double n1, n2, answer;
            n1 = Convert.ToDouble(FirstNumTextBox.Text);
            n2 = Convert.ToDouble(SecNumTextBox.Text);
            answer = Math.Pow(n1, n2);
            ResultLabel2.Text = answer.ToString();
            this.BackColor = Color.Cornsilk;
        }

        /// <summary>
        /// This method was used for the average button which will find the average of the two numbers that were input
        /// </summary>
        private void AverageButton_Click(object sender, EventArgs e)
        {
            double n1, n2, answer;
            n1 = Convert.ToDouble(FirstNumTextBox.Text);
            n2 = Convert.ToDouble(SecNumTextBox.Text);
            answer = (n1 + n2) / 2;
            ResultLabel2.Text = answer.ToString();
            this.BackColor = Color.Firebrick;
        }

        /// <summary>
        /// This method was used for the clear button which will clear the two numbers in the text boxes
        /// </summary>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            FirstNumTextBox.Text = "";
            SecNumTextBox.Text = "";
        }
    }
}
