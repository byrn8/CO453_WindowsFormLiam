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
    /// This class was used for the monkey form in tasks 3.5 and 3.6 (MonkeyForm)
    /// </summary>
    public partial class MonkeyForm : Form
    {
        int x, y, monkeyHits, missHits;
        Random rand = new Random();
        

        /// <summary>
        /// Constructor used for the monkey form
        /// </summary>
        public MonkeyForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method was used for the start button and will start the timers
        /// </summary>
        private void StartButton_Click(object sender, EventArgs e)
        {
            Timer1.Enabled = true;
            Timer2.Enabled = true;
            Timer3.Enabled = true;
            Timer4.Enabled = true;
            Timer5.Enabled = true;
        }

        /// <summary>
        /// This method was used for the stop button and will stop the timers
        /// </summary>
        private void StopButton_Click(object sender, EventArgs e)
        {
            Timer1.Enabled = false;
            Timer2.Enabled = false;
            Timer3.Enabled = false;
            Timer4.Enabled = false;
            Timer5.Enabled = false;
        }

        /// <summary>
        /// This method was used for the quit button and will exit the application once pressed
        /// </summary>
        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This method was used for the picture box 2 and will display a message when pressed
        /// </summary>
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            monkeyHits = monkeyHits + 1;
            HitsNumberLabel.Text = monkeyHits.ToString();
            MessageBox.Show("Ouch! You HIT Me!", "Reply");
        }

        /// <summary>
        /// This method was used for the timer 2 and picture box 2 and will generate a random number which will corelate to a place on the form
        /// </summary>
        private void Timer2_Tick(object sender, EventArgs e)
        {
            x = rand.Next(this.Width - 100);
            y = rand.Next(this.Height - 100);
            PictureBox2.Left = x;
            PictureBox2.Top = y;
            Refresh();
        }

        /// <summary>
        /// This method was used for the picture box 3 and will display a message when pressed
        /// </summary>
        private void PictureBox3_Click(object sender, EventArgs e)
        {
            monkeyHits = monkeyHits + 1;
            HitsNumberLabel.Text = monkeyHits.ToString();
            MessageBox.Show("Ouch! You HIT Me!", "Reply");
        }

        /// <summary>
        /// This method was used for the timer 3 and picture box 3 and will generate a random number which will corelate to a place on the form
        /// </summary>
        private void Timer3_Tick(object sender, EventArgs e)
        {
            x = rand.Next(this.Width - 100);
            y = rand.Next(this.Height - 100);
            PictureBox3.Left = x;
            PictureBox3.Top = y;
            Refresh();
        }

        /// <summary>
        /// This method was used for the picture box 4 and will display a message when pressed
        /// </summary>
        private void PictureBox4_Click(object sender, EventArgs e)
        {
            monkeyHits = monkeyHits + 1;
            HitsNumberLabel.Text = monkeyHits.ToString();
            MessageBox.Show("Ouch! You HIT Me!", "Reply");
        }

        /// <summary>
        /// This method was used for the timer 4 and picture box 4 and will generate a random number which will corelate to a place on the form
        /// </summary>
        private void Timer4_Tick(object sender, EventArgs e)
        {
            x = rand.Next(this.Width - 100);
            y = rand.Next(this.Height - 100);
            PictureBox4.Left = x;
            PictureBox4.Top = y;
            Refresh();
        }

        /// <summary>
        /// This method was used for the picture box 5 and will display a message when pressed
        /// </summary>
        private void PictureBox5_Click(object sender, EventArgs e)
        {
            monkeyHits = monkeyHits + 1;
            HitsNumberLabel.Text = monkeyHits.ToString();
            MessageBox.Show("Ouch! You HIT Me!", "Reply");
        }

        /// <summary>
        /// This method was used for the timer 5 and picture box 5 and will generate a random number which will corelate to a place on the form
        /// </summary>
        private void Timer5_Tick(object sender, EventArgs e)
        {
            x = rand.Next(this.Width - 100);
            y = rand.Next(this.Height - 100);
            PictureBox5.Left = x;
            PictureBox5.Top = y;
            Refresh();
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
        /// This method was used for to display a message everytime you clicked the form instead of the monkey
        /// </summary>
        private void MonkeyForm_MouseDown(object sender, MouseEventArgs e)
        {
            missHits = missHits + 1;
            MissNumberLabel.Text = missHits.ToString();
            MessageBox.Show("You MISSED!");
        }

        /// <summary>
        /// This method was used for the timer 1 and picture box 1 and will generate a random number which will corelate to a place on the form
        /// </summary>
        private void Timer_Tick(object sender, EventArgs e)
        {
            x = rand.Next(this.Width - 100);
            y = rand.Next(this.Height - 100);
            PictureBox1.Left = x;
            PictureBox1.Top = y;
            Refresh();
        }
    }
}
