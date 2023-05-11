using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Inciso6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numero = 1;
            var cantidad = 0;
            int[] numerosIngresados = new int[100];
            while (numero != 0)
            {
                WriteLine("Ingrese numero entero:");
                numero = Convert.ToInt32(ReadLine());
                if(numero != 0)
                {
                    numerosIngresados[cantidad] = numero;
                    cantidad++;
                    WriteLine("\n---------------------------------------------------");
                    WriteLine("Cantidad: " + cantidad);
                    var mayor = BuscarMayor(numerosIngresados, cantidad);
                    var menor = BuscarMenor(numerosIngresados, cantidad);
                    DiferenciaDosNumeros(mayor, menor);
                    WriteLine("---------------------------------------------------");
                }
                
            }
            ReadKey();
        }
        public static int BuscarMayor(int[] numeros, int longitud)
        {
            var masGrande = numeros[0];
            for (int i = 0; i < longitud; i++)
            {
                if (numeros[i] > masGrande)
                {
                    masGrande= numeros[i];
                }
            }
            WriteLine("El numero más grande es: " + masGrande);
            return masGrande;
        }

        public static int BuscarMenor(int[] numeros, int longitud)
        {
            var masPequenio = numeros[0];
            for (int i = 0; i < longitud; i++)
            {
                if (numeros[i] < masPequenio)
                {
                    masPequenio = numeros[i];
                }
            }
            WriteLine("El numero más bajo es: " + masPequenio);
            return masPequenio;
        }
        
        public static void DiferenciaDosNumeros(int alto, int bajo)
        {
            
            WriteLine((alto)+ " - " + (bajo)+" = " + (alto- bajo));
        }
    }
}
