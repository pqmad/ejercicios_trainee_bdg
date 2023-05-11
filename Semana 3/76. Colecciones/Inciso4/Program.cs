using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Inciso4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listNumeros = new List<int>();
            var cantidad = 0;
            while (cantidad < 10)
            {
                WriteLine("Escribir un número:");
                var numeroIngresado = Convert.ToInt32(ReadLine());
                listNumeros.Add(numeroIngresado);
                cantidad++;
            }
            WriteLine("\n---------------------------------------------------");
            WriteLine($"El numero mayor es: {BuscarNumeroMasAlto(listNumeros)}");
            WriteLine("---------------------------------------------------");
            WriteLine($"El numero menor es: {BuscarNumeroMasBajo(listNumeros)}");
            WriteLine("---------------------------------------------------");
            ReadKey();
        }
        public static int BuscarNumeroMasBajo(List<int> listNumeros)
        {
            var numero = listNumeros[0];
            foreach (var item in listNumeros)
            {
                if(item < numero)
                {
                    numero= item;
                }
            }
            return numero;
        }

        public static int BuscarNumeroMasAlto(List<int> listNumeros)
        {
            var numero = listNumeros[0];
            foreach (var item in listNumeros)
            {
                if (item > numero)
                {
                    numero = item;
                }
            }
            return numero;
        }
    }
}
