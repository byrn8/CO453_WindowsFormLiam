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
    /// This class was used for the winning splash screen in task 2.8 (WinningSplashForm)
    /// </summary>
    public partial class WinningSplashForm : Form
    {
        /// <summary>
        /// Constructor used for the winning splash screen
        /// </summary>
        public WinningSplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method will exit the form when clicked
        /// </summary>
        private void WinningSplashForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
