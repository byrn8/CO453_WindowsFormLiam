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
    /// This class was used for the unit 4 independent study project (MainDataEntryForm)
    /// </summary>
    public partial class MainDataEntryForm : Form
    {
        int teacherTotal = 0;

        /// <summary>
        /// Constructor used for the data entry form
        /// </summary>
        public MainDataEntryForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method was used for the quit button and will exit the application when pressed
        /// </summary>
        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This method was used to display the bill form and the values for the form
        /// </summary>
        private void SeeBillButton_Click(object sender, EventArgs e)
        {
            BillForm newForm = new BillForm();
            newForm.Show();

            newForm.NameResultLabel.Text = NameTextbox.Text;
            newForm.SchoolResultLabel.Text = SchoolCombobox.Text;

            switch (DiningCombobox.Text)
            {
                case "None": newForm.TBResultLabel.Text = "£50"; break;
                case "Lunch": newForm.TBResultLabel.Text = "£60"; break;
                case "Dinner": newForm.TBResultLabel.Text = "£65"; break;
                case "Lunch + Dinner": newForm.TBResultLabel.Text = "£75"; break;
            }
        }

        /// <summary>
        /// This method was used to display the total form and the number of overall teachers
        /// </summary>
        private void TotalButton_Click(object sender, EventArgs e)
        {
            teacherTotal++;
            
            TotalForm newForm = new TotalForm();
            newForm.Show();

            newForm.TTResultLabel.Text = Convert.ToString(teacherTotal);
        }
    }
}
