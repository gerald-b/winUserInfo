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
            bool showUserDomain = false;

            foreach (String arg in args)
            {
                if (arg.ToUpper().Equals("-U") ||
                    arg.ToUpper().Equals("--USER")
                    )
                {
                    showUserName = true;
                }

                if (arg.ToUpper().Equals("-UD") ||
                    arg.ToUpper().Equals("--USER-DOMAIN")
                    )
                {
                    showUserDomain = true;
                }
            }

            String msg = String.Empty;
            msg += Environment.NewLine;

            if (showUserName)
            {
                msg += "Username:\t" + Environment.UserName;
                msg += Environment.NewLine;
            }

            if (showUserDomain)
            {
                msg += "Userdomain:\t" + Environment.UserDomainName;
                msg += Environment.NewLine;
            }

            msg += Environment.NewLine;

            Console.WriteLine(msg);

        }
    }
}
