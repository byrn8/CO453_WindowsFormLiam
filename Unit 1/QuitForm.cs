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
    /// This class was used for task 1.7 (QuitForm)
    /// </summary>
    public partial class QuitForm : Form
    {
        /// <summary>
        /// Constructor used for the quit form
        /// </summary>
        public QuitForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This was the method used for the quit form and if you click then the application will close
        /// </summary>
        private void QuitForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
