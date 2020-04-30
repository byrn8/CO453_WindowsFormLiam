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
    /// This class was used for task 1.6 (SplashForm)
    /// </summary>
    public partial class SplashForm : Form
    {
        /// <summary>
        /// Constructor used for the splash form
        /// </summary>
        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This was the method used to close the splash screen if the user clicks on it
        /// </summary>
        private void Splash_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
