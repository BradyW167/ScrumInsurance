using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowserGitHubDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the .
        /// </summary>
        /// Dr. R is here.
        /// Dr. R was here.
        /// Go Dawgs
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WebBrowserGUI());
        }
    }
}
