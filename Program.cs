using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullsAndCows
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CultureInfo inf = new CultureInfo(System.Threading.Thread.CurrentThread.CurrentCulture.Name);
            System.Threading.Thread.CurrentThread.CurrentCulture = inf;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var view = new Form1();
            var mdl = new Model();
            var ctr = new Controller(view, mdl);
            Application.Run(view);
        }
    }
}
