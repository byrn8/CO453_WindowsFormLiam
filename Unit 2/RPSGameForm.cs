using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CO453_WindowsFormLiam.Unit_2
{
    /// <summary>
    /// This class was used for task 2.1 to ... (RPSGameForm)
    /// </summary>
    public partial class RPSGameForm : Form
    {
        int compChoice, userChoice;
        int userScore = 0, compScore = 0;

        /// <summary>
        /// Constructor used for the RPS game form
        /// </summary>

        public RPSGameForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method was used for the rock radio button and will display the rock image when selected
        /// </summary>
        private void RockRButton_CheckedChanged(object sender, EventArgs e)
        {
            userChoice = 1;
            UserPBox.Image = Image.FromFile("rock.png");
        }

        /// <summary>
        /// This method was used for the paper radio button and will display the paper image when selected
        /// </summary>
        private void PaperRButton_CheckedChanged(object sender, EventArgs e)
        {
            userChoice = 2;
            UserPBox.Image = Image.FromFile("paper.jpg");
        }

        /// <summary>
        /// This method was used for the scissors radio button and will display the scissors image when selected
        /// </summary>
        private void ScissorsRButton_CheckedChanged(object sender, EventArgs e)
        {
            userChoice = 3;
            UserPBox.Image = Image.FromFile("scissors.png");
        }

        /// <summary>
        /// This method was used for the quit button and will exit the application when clicked
        /// </summary>
        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This method was used for play button and will randomly select an image for the computer to use
        /// </summary>
        private void PlayButton_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            compChoice = r.Next(3) + 1;

            if (compChoice == 1)
            {
                ComputerPBox.Image = Image.FromFile("rock.png");
            }
            else if (compChoice == 2)
            {
                ComputerPBox.Image = Image.FromFile("paper.jpg");
            }
            else if (compChoice == 3)
            {
                ComputerPBox.Image = Image.FromFile("scissors.png");
            }

            checkResult();

            UserScoreLabel.Text = userScore.ToString();
            CompScoreLabel.Text = compScore.ToString();

            if (userScore == 20 && compScore == 20)
            {
                DrawingSplashForm SScreen = new DrawingSplashForm();
                SScreen.ShowDialog();
            }
            else if (userScore == 20)
            {
                WinningSplashForm SScreen = new WinningSplashForm();
                SScreen.ShowDialog();
            }
            else if (compScore == 20)
            {
                LosingSplashForm SScreen = new LosingSplashForm();
                SScreen.ShowDialog();
            }
        }

        /// <summary>
        /// This method was used for the images that load with the form
        /// </summary>
        private void RPSGameForm_Load(object sender, EventArgs e)
        {
            UserPBox.Image = Image.FromFile("rps.png");
            ComputerPBox.Image = Image.FromFile("rps.png");

            RPSSplashForm SScreen = new RPSSplashForm();
            SScreen.ShowDialog();
        }

        /// <summary>
        /// This method is used to check the result of game and see if the player has won, lost or drew
        /// </summary>
        private void checkResult()
        {
            if (compChoice == userChoice)
            {
                ResultLabel.Text = "It’s a DRAW!";
                ResultLabel.BackColor = Color.Empty;
                ResultLabel.ForeColor = Color.Empty;
                userScore = userScore + 1;
                compScore = compScore + 1;
            }
            else if (compChoice == 1 && userChoice == 2 || compChoice == 2 && userChoice == 3 || compChoice == 3 && userChoice == 1)
            {
                ResultLabel.Text = "You WIN!";
                ResultLabel.BackColor = Color.Aqua;
                ResultLabel.ForeColor = Color.Pink;
                userScore = userScore + 2;
            }
            else if (compChoice == 2 && userChoice == 1 || compChoice == 3 && userChoice == 2 || compChoice == 1 && userChoice == 3)
            {
                ResultLabel.Text = "You LOSE!";
                ResultLabel.BackColor = Color.Empty;
                ResultLabel.ForeColor = Color.Empty;
                compScore = compScore + 2;
            }
        }
    }
}
