using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inciso2_Framework_4._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un nombre:");
            var nombre = Console.ReadLine();
            Console.WriteLine("Escriba de una ciudad:");
            var ciudad = Console.ReadLine();
            Console.WriteLine("¡Hola, " + nombre + "! bienvenido a "+ ciudad);
            Console.Read();

        }
    }
}
