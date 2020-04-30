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
    /// This class was used for the unit 4 independent study project (BillForm)
    /// </summary>
    public partial class BillForm : Form
    {
        /// <summary>
        /// Constructor used for the bill form
        /// </summary>
        public BillForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method was used for the close button and will close the bill form when pressed
        /// </summary>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// This method was used for the accept bill button and will send some of the data to certain variables
        /// </summary>
        private void AcceptBillButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your submission has been sent", "Reply");

            this.Close();
        }
    }
}
