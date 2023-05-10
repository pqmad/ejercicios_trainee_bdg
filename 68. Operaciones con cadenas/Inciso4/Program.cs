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

            var cadena= new StringBuilder();
            var contador = 0;
            while (contador<4)
            {
                WriteLine("Escribe un número:");
                var numeroIngresado = ReadLine();
                switch (contador)
                {
                    case 0:
                        cadena.Append($"El primer numero introducido es el {numeroIngresado}, ");
                        break;
                    case 1:
                        cadena.Append($"despues han introducido el {numeroIngresado} ");
                        break;
                    case 2:
                        cadena.Append($"y {numeroIngresado} ");
                        break;  
                    case 3:
                        cadena.Append($"y por ultimo el {numeroIngresado}");
                        break;
                }
                
                contador++;
            }
            WriteLine($"\n{cadena}");
            ReadKey();
        }
    }
}
