using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Inciso5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 90; i > 64; i--)
            {
                WriteLine("\t"+Convert.ToChar(i));
            }
            ReadKey();
        }
    }
}
