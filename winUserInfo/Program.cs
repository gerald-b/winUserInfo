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
            bool showUserName = false;
            foreach (String arg in args)
            {
                if (arg.ToUpper().Equals("-U") ||
                    arg.ToUpper().Equals("--USER")
                    )
                {
                    showUserName = true;
                }
            }

            String msg = String.Empty;
            msg += Environment.NewLine;

            if (showUserName)
            {
                msg += "Username: " + Environment.UserName;
            }

            msg += Environment.NewLine;

            Console.WriteLine(msg);

        }
    }
}
