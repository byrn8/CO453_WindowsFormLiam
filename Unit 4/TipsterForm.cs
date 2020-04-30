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
    /// This class was used for the tipster form for unit 4 (TipsterForm)
    /// </summary>
    public partial class TipsterForm : Form
    {
        double n1, n2, answer;

        /// <summary>
        /// Constructor used for the tipster form
        /// </summary>
        public TipsterForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method was used for the quit button and will exit the appliction when pressed
        /// </summary>
        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This method was used to load in the picture box image when the form loads
        /// </summary>
        private void TipsterForm_Load(object sender, EventArgs e)
        {
            PictureBox.Image = Image.FromFile("tip.jpg");
        }

        /// <summary>
        /// This method is used to display the results form when pressed
        /// </summary>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                n1 = Convert.ToDouble(BillTextbox.Text);
                n2 = Convert.ToDouble(PeopleListbox.Text);
                answer = n1 / n2;

                ResultsForm newForm = new ResultsForm();
                newForm.Show();

                newForm.TBResultLabel.Text = BillTextbox.Text;
                newForm.PeopleResultLabel.Text = PeopleListbox.Text;
                newForm.EPResultLabel.Text = answer.ToString();
            }
            catch
            {
                MessageBox.Show("Error in Data Entry");
            }
        }
    }
}
