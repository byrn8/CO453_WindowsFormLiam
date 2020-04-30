using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CO453_WindowsFormLiam.Unit_3
{
    /// <summary>
    /// This class was used for the my pad form in tasks 3.7 to 3.10 (MyPadForm)
    /// </summary>
    public partial class MyPadForm : Form
    {
        /// <summary>
        /// Constructor used for the my pad form
        /// </summary>
        public MyPadForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method was used for the cut button in the edit menu
        /// </summary>
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRTextBox.Cut();
        }

        /// <summary>
        /// This method was used for the copy button in the edit menu
        /// </summary>
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRTextBox.Copy();
        }

        /// <summary>
        /// This method was used for the paste button in the edit menu
        /// </summary>
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRTextBox.Paste();
        }

        /// <summary>
        /// This method was used for the undo button in the edit menu
        /// </summary>
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRTextBox.Undo();
        }

        /// <summary>
        /// This method was used for the exit button in the file menu
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This method was used for the save button in the file menu
        /// </summary>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog.ShowDialog();
            MainRTextBox.SaveFile(SaveFileDialog.FileName);
        }

        /// <summary>
        /// This method was used for the open button in the file menu
        /// </summary>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRTextBox.LoadFile(OpenFileDialog.FileName); //doesn't work
        }

        /// <summary>
        /// This method was used for the font button in the format menu
        /// </summary>
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog.ShowDialog();
            MainRTextBox.Font = FontDialog.Font;
        }

        /// <summary>
        /// This method was used for the background colour button in the format menu
        /// </summary>
        private void backgroundColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog.ShowDialog();
            MainRTextBox.BackColor = ColorDialog.Color;
        }

        /// <summary>
        /// This method was used for the foreground colour button in the format menu
        /// </summary>
        private void foregroundColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog.ShowDialog();
            MainRTextBox.ForeColor = ColorDialog.Color;
        }

        /// <summary>
        /// This method was used for the scroll bar and will change the size of the font based on where the bar is
        /// </summary>
        private void HorizontalScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            int x = 10;
            
            Font f = new Font(MainRTextBox.Font.Name, x, FontStyle.Regular);
            MainRTextBox.SelectionFont = f;
        }
    }
}
