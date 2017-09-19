using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public static void Double()
        {
            Console.WriteLine("1." + Assembly.GetEntryAssembly().FullName);
            Console.WriteLine("2." + Assembly.GetExecutingAssembly().FullName);
        }
    }
}
