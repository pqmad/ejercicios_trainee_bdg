using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Reto_Semana_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Escribe una palabra:");
            var palabra = ReadLine().ToLower();
            if (PalabraInversa(palabra) ==palabra)
            {
                WriteLine("Si es palíndromo");
            }
            else
            {
                WriteLine("No es palíndromo");
            }
            ReadKey();
        }
        public static string PalabraInversa(string palabra)
        {
            var inversa = "";
            for (int i = palabra.Length-1; i>=0; i--)
            {
                inversa+= palabra[i];
            }
            return inversa;
        }
    }
}
