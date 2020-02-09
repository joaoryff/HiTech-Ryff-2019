using HiTech_Ryff_2019.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HitechEntityFramework;

namespace HiTech_Ryff_2019
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
            //Application.Run(new MIS());
           // Application.Run(new Sales());
            Application.Run(new HitechEntityFramework.LogIn());
        }
    }
}
