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
    /// This class was used for the drawing splash screen in task 2.8 (DrawingSplashForm)
    /// </summary>
    public partial class DrawingSplashForm : Form
    {
        /// <summary>
        /// Constructor used for the drawing splash screen
        /// </summary>
        public DrawingSplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method will exit the form when clicked
        /// </summary>
        private void DrawingSplashForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
