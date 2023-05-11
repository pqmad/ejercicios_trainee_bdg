using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Inciso2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var opcionElegida = 0;
            while (opcionElegida != 5)
            {
                WriteLine("\n________________________________________________________________");

                WriteLine("\nElige una opción: \n");
                WriteLine("1) Suma");
                WriteLine("2) Resta");
                WriteLine("3) Multiplicacion");
                WriteLine("4) Division");
                WriteLine("5) Salir");
                opcionElegida = Convert.ToInt32(ReadLine());

                if(opcionElegida != 5)
                {
                    WriteLine("Ingresa primer numero:");
                    var num1 = Convert.ToDouble(ReadLine());
                    WriteLine("Ingresa segundo numero:");
                    var num2 = Convert.ToDouble(ReadLine());

                    var resultado = 0.0;
                    switch (opcionElegida)
                    {
                        case 1:
                            resultado = SumaDosNumeros(num1, num2);
                            break;
                        case 2:
                            resultado = RestaDosNumeros(num1, num2);
                            break;
                        case 3:
                            resultado = MultiplicacionDosNumeros(num1, num2);
                            break;
                        case 4:
                            resultado = DivisionDosNumeros(num1, num2);
                            break;
                        default:
                            break;
                    }
                    WriteLine("El resultado es: " + resultado);
                }
                
            }
        }

        public static double SumaDosNumeros(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double RestaDosNumeros(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double MultiplicacionDosNumeros(double num1, double num2)
        {
            return num1 * num2;
        }
        public static double DivisionDosNumeros(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
