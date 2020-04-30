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
    /// This class was used for the spalsh screen in task 2.7 (RPSSplashForm)
    /// </summary>
    public partial class RPSSplashForm : Form
    {
        /// <summary>
        /// Constructor used for the RPS splash screen
        /// </summary>
        public RPSSplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method was used to close the splash screen when the user clicks the form
        /// </summary>
        private void RPSSplashForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
