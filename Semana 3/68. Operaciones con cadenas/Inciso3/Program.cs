using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Inciso3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Escribir una frase:");
            var frase = ReadLine();
            var cantPalabras= frase.Split(' ').Length;

            if (cantPalabras >= 4 && frase.Length >= 20)
            {
                Inicio(frase);
            }
            else
            {
                WriteLine("La frase no cumple los requisitos, 4 palabras y 20 caracteres");
            }
            ReadKey();
        }
        public static void Inicio(string frase)
        {
            // logitud de la cadena
            WriteLine($"Longitud:\t{frase.Length} caracteres");

            // remplazar la letra "a" por "x"
            frase=frase.Replace("a", "x");
            frase=frase.Replace("A", "X");
            WriteLine($"Remplazar la letra \"a\" por \"x\":\t{frase}");

            // cadena en mayúsculas y minusculas
            WriteLine($"Cadena en mayúsculas:\t{frase.ToUpper()}");
            WriteLine($"Cadena en minúsculas:\t{frase.ToLower()}");

            // removiendo las 3 primeras letras
            WriteLine($"removiendo las 3 primeras letras:\t{frase.Substring(3,(frase.Length- 3))}");

            //extrayendo las letras en las posiciones de la 5 a la 10
            WriteLine($"extrayendo las letras en las posiciones de la 5 a la 10:\t{frase.Remove(5, 5)}");

            //invierte la cadena
            WriteLine($"invierte la cadena:\t{CadenaInversa(frase)}");

            //numero de palabras que tiene la frase
            WriteLine($"numero de palabras que tiene la frase:\t{frase.Split(' ').Length}");

            //escribe únicamente la tercera palabra
            WriteLine($"escribe únicamente la tercera palabra:\t{frase.Split(' ')[2]}");
        }

        public static string CadenaInversa(string frase)
        {
            var inversa = "";
            for (int i = (frase.Length - 1); i >= 0; i--)
            {
                inversa += frase[i];
            }
            return inversa;
        }
    }
}
