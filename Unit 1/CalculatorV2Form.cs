using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CO453_WindowsFormLiam.Unit_1
{
    /// <summary>
    /// This class was used for the calculator v2 form in task 1.11 (CalculatorV2Form)
    /// </summary>
    public partial class CalculatorV2Form : Form
    {
        /// <summary>
        /// Constructor used for the calculator v2 form
        /// </summary>
        public CalculatorV2Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method was used for the quit button and will quit the applicationnwhen pressed
        /// </summary>
        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
