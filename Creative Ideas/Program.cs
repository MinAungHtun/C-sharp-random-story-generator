using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cudafy.Compilers;
using Cudafy.Translator;
using Cudafy.Host;
using System.Data.Objects;
using System.Runtime.InteropServices;
using WMPLib;

namespace Creative_Ideas
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
            Application.Run(new Start());
        }
    }
}
