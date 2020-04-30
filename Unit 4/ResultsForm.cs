using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CO453_WindowsFormLiam.Unit_4
{
    /// <summary>
    /// This class was used for the results form for unit 4 (ResultsForm)
    /// </summary>
    public partial class ResultsForm : Form
    {
        /// <summary>
        /// Constructor used for the results form
        /// </summary>
        public ResultsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method is used for the close button and will close the reults form when presses
        /// </summary>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
