using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Security.Permissions;

namespace RegRead
{
    class Program
    {
        
        static int Main(string[] args)
        {
            try
            {
                var targetRegistry = args[1].Substring(0, 4);
                var targetKey = args[1].Substring(5);

                string targetValue = null;
                if (args[2].ToLower() == "/v")
                {
                    targetValue = args[3];
                }
                else
                {
                    return 1;
                }

                var hkey = targetRegistry == "HKLM" ? Registry.LocalMachine : Registry.CurrentUser;
                var key = hkey.OpenSubKey(targetKey);



                var result = key.GetValue(targetValue);
                Console.WriteLine();
                Console.WriteLine(key.Name);
                Console.WriteLine("    {0}    REG_SZ    {2}", targetValue, key.GetValueKind(targetValue), result);
                Console.WriteLine();
                Console.WriteLine();

                return 0;
            }
            catch
            {
                return 1;
            }
        }
    }
}
