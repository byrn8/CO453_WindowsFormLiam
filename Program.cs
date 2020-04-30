using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CO453_WindowsFormLiam.Unit_1;
using CO453_WindowsFormLiam.Unit_2;
using CO453_WindowsFormLiam.Unit_3;
using CO453_WindowsFormLiam.Unit_4;

namespace CO453_WindowsFormLiam
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new
            //WelcomeForm() //Used for tasks 1.1 to 1.3
            //DataEntryForm() //Used for task 1.4
            //CalculatorForm() //Used for tasks 1.5 to 1.10
            //CalculatorV2Form() //Used for task 1.11 //Task 1.11 not fully functional
            //RPSGameForm() //Used for tasks 2.1 to 2.8
            //CurrencyConverterForm() //Used for task 3.1
            //PizzaShopForm() //Used for task 3.2
            //PoshNoshForm() //Used for tasks 3.3 to 3.4
            //MonkeyForm() //Used for tasks 3.5 to 3.6 and 3.12
            //MyPadForm() //Used for tasks 3.7 to 3.10 and 3.13 //Task 3.13 not fully functional
            //TargetForm() //Used for task 3.11 //Task 3.11 not fully functional
            //PictureForm() //Used for task 3.14
            //TipsterForm() //Used for tasks 4.1 to 4.6
            MainDataEntryForm() //Used for tasks 4.7 to 4.9
            );
        }
    }
}
