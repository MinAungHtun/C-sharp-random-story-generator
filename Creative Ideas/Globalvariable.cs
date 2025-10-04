using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creative_Ideas
{
    static class Globalvariable
    {
        public static string globalVar = "Normal User";

        public static string GlobalVar
        {
            get { return globalVar; }
            set { globalVar = value; }
        }
    }
}
