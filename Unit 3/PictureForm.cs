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
    /// This class was used for the picture form in task 3.14 (PictureForm)
    /// </summary>
    public partial class PictureForm : Form
    {
        /// <summary>
        /// Constructor used for the picture form
        /// </summary>
        public PictureForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method was used for the quit button and will quit the application
        /// </summary>
        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This method was used for the combo box and will change the picture based on the choice you make
        /// </summary>
        private void ChoiceCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ChoiceCBox.Text)
            {
                case "King Kong": ChoicePBox.Image = Image.FromFile("kk.jpg"); break;
                case "Big Foot": ChoicePBox.Image = Image.FromFile("bf.png"); break;
                case "Mogwai": ChoicePBox.Image = Image.FromFile("mw.jpg"); break;
                case "Loch Ness Monster": ChoicePBox.Image = Image.FromFile("lnm.png"); break;
                case "Alien": ChoicePBox.Image = Image.FromFile("al.png"); break;
                case "Godzilla": ChoicePBox.Image = Image.FromFile("gz.jpg"); break;
            }
        }
    }
}
