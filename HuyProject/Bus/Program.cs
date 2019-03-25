using Bus.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus
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
<<<<<<< HEAD
            Application.Run(new Bus.View.MainForm());
=======
            Application.Run(new Bus.View.Schudeling());
>>>>>>> 95d01482e1d81adbfd817bb88cb848f0fa4a1d00
        }
    }
}
