using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yunos_Aifa_02_Lab
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var QueuingForm = new QueuingForm();
            var CashierWindowQueuingForm = new CashierWindowQueueForm();
            CashierWindowQueuingForm.Show();
            Application.Run(new QueuingForm());
        }
    }
}
