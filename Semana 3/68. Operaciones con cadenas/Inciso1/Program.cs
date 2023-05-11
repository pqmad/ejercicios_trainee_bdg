using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Inciso1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Escribe un nombre:");
            var nombre = ReadLine().ToLower();
            if (nombre == "alejandro")
            {
                WriteLine("Hola!");
            }
            else {
                WriteLine("No te conozco"); 
            }

            ReadKey();
        }
    }
}
