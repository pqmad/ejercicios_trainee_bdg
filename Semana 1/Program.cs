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
            Console.WriteLine("Ingrese un número:");
            var numeroIgresado = Console.ReadLine();
            var numero = Convert.ToDouble(numeroIgresado);

            #region Si es o no mayor de 100
            if (numero > 100)
            {
                Console.WriteLine("El "+numero+" es mayor a 100");
            }
            else if(numero == 100)
            {
                Console.WriteLine("El "+numero+" es igual a 100");
            }
            else
            {
                Console.WriteLine("El "+numero+" es menor a 100");
            }
            #endregion
            
            #region Si es par o impar
            if ((numero%2) == 0)
            {
                Console.WriteLine("El "+numero+" es par");
            }
            else
            {
                Console.WriteLine("El "+numero+" es impar");
            }
            #endregion
            
            #region Si es primo o no
            var esPrimo = true;
            for (int i = 2; i < numero; i++)
            {
                if ((numero%i)==0)
                {
                    esPrimo=false;
                }
            }
            if (esPrimo)
            {
                Console.WriteLine("El "+numero+" es primo");
            }
            else
            {
                Console.WriteLine("El "+numero+" no es primo");
            }
            #endregion

        }
    }
}
