using System;
using System.Collections;
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
            ArrayList ListNumeros= new ArrayList();
            LlenarArreglo(ref ListNumeros);
            var sumaNumeros = 0;
            foreach (var item in ListNumeros)
            {
                sumaNumeros +=  Convert.ToInt32(item);
                WriteLine("\t"+sumaNumeros);
            }
            ReadKey();
        }
        public static void LlenarArreglo(ref  ArrayList ListNumeros)
        {
            for (int i = 1; i <= 1000; i++)
            {
                ListNumeros.Add(i);
            }
        }
    }
}
