using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winUserInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showVersion = false;

            foreach (String arg in args)
            {
                if (arg.ToUpper().Equals("-V") ||
                    arg.ToUpper().Equals("-VERSION")
                    )
                {
                    showVersion = true;
                }
            }

            String msg = String.Empty;

            if (showVersion)
            {
                msg = getVersionTxt();
                Console.WriteLine(msg);
                return;
            }

        }

        private static string getVersionTxt()
        {
            ClsAbout about = new ClsAbout();

            String msg = String.Empty;
            msg += about.getProductName() + " - v" + about.getVersion();
            msg += Environment.NewLine;
            msg += "Author(s): " + about.getCompany();
            msg += Environment.NewLine;
            msg += "License: " + about.getCopyright();
            msg += Environment.NewLine;

            return msg;
        }
    }
}
