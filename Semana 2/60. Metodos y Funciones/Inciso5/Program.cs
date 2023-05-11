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
            WriteLine("Ingrese número:");
            var numero=Convert.ToInt32(ReadLine());
            WriteLine("\n---------------------------------------------");
            for (int i = 0; i < 11; i++)
            {
                Imprimir(numero, i, MultiplicacionDosNumeros(i, numero));
            }
            WriteLine("---------------------------------------------");
            ReadKey();
        }
        public static void Imprimir(int numero1, int numero2, int resultado)
        {
            WriteLine(numero1 + " x " + numero2 + " = " + resultado);
        }
        public static int MultiplicacionDosNumeros(int numero1, int numero2)
        {
            return numero1*numero2;
        }
    }
}
