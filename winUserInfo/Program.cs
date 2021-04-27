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
        }
    }
}
