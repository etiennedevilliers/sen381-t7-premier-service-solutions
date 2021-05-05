using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Layer.Access;
using Presentation.Forms.Welcome;

namespace sen381_t7_premier_service_solutions
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        /*
            Remove Technician - Children
            Mid-Schedule operations
            Has to select
            Technicians who have no work
            Exception handling when deleting children
        */

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}