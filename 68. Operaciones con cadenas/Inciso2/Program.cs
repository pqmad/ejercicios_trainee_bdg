using System;
using static System.Console;

namespace Inciso2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Escribir una palabra");
            var palabraIngresada= ReadLine().ToLower();
            WriteLine(PalabraInversa(palabraIngresada));
            ReadKey();
        }
        public static string PalabraInversa(string palabra)
        {
            var inversa = "";
            for (int i = (palabra.Length-1);i>=0; i--)
            {
                inversa += palabra[i];
            }
            return inversa;
        }
    }
}
