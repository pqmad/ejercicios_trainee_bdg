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
            List<int> listPares = new List<int>();
            List<int> listImpares = new List<int>();
            var cantidad = 0;
            while (cantidad<10)
            {
                WriteLine("Escribir un número:");
                var numeroIngresado= Convert.ToInt32(ReadLine());
                if(numeroIngresado%2 == 0) {
                    listPares.Add(numeroIngresado);
                }
                else
                {
                    listImpares.Add(numeroIngresado);
                }
                cantidad++;
            }
            WriteLine("\n---------------------------------------------------");
            WriteLine($"La sumatoria de los numeros pares es: {SumarArreglo(listPares)}");
            WriteLine("---------------------------------------------------");
            WriteLine($"La sumatoria de los numeros impares es: {SumarArreglo(listImpares)}");
            WriteLine("---------------------------------------------------");
            ReadKey();
        }
        public static int SumarArreglo(List<int> list)
        {
            var resultado = 0;
            foreach (var item in list)
            {
                resultado += item;
            }
            return resultado;
        }
    }
}
