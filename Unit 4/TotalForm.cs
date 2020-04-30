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
    /// This class was used for the unit 4 independent study project (TotalForm)
    /// </summary>
    public partial class TotalForm : Form
    {
        /// <summary>
        /// Constructor used for the total form
        /// </summary>
        public TotalForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method was used for the close button and will close the total form when pressed
        /// </summary>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
