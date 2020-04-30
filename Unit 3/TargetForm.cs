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
    /// This class was used for the target form in task 3.11 (TargetForm)
    /// </summary>
    public partial class TargetForm : Form
    {
        int x, y, monkeyHits, missHits;
        Random rand = new Random();

        /// <summary>
        /// This method was used for to display a message everytime you clicked the form instead of the target
        /// </summary>
        private void TargetForm_MouseDown(object sender, MouseEventArgs e)
        {
            missHits = missHits + 1;
            MissNumberLabel.Text = missHits.ToString();
            MessageBox.Show("You MISSED!");
        }

        /// <summary>
        /// This method was used for the quit button and will exit the application once pressed
        /// </summary>
        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This method was used for the start button and will start the timers
        /// </summary>
        private void StartButton_Click(object sender, EventArgs e)
        {
            Timer.Enabled = true;
        }

        /// <summary>
        /// This method was used for the stop button and will stop the timers
        /// </summary>
        private void StopButton_Click(object sender, EventArgs e)
        {
            Timer.Enabled = false;
        }

        /// <summary>
        /// This method was used for the picture box and will display a message when pressed
        /// </summary>
        private void PictureBox_Click(object sender, EventArgs e)
        {
            monkeyHits = monkeyHits + 1;
            HitsNumberLabel.Text = monkeyHits.ToString();
            MessageBox.Show("Ouch! You HIT Me!", "Reply");
        }

        /// <summary>
        /// This method was used for the timer and picture box and will generate a random number which will corelate to a place on the form
        /// </summary>
        private void Timer_Tick(object sender, EventArgs e)
        {
            x = rand.Next(this.Width - 100);
            y = rand.Next(this.Height - 100);
            PictureBox.Left = x;
            PictureBox.Top = y;
            Refresh();
        }

        /// <summary>
        /// Constructor used for the target form
        /// </summary>
        public TargetForm()
        {
            InitializeComponent();
        }
    }
}
