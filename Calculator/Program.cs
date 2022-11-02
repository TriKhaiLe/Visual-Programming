using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.IO;
using System.Text; namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Calculator CalculatorZ = new Calculator();
            Application.Run(CalculatorZ);

        }

        
    }
}
