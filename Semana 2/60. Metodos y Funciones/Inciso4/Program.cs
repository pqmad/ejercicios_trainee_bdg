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
            WriteLine("Ingrese un caracter:");
            var caracterIngresado = ReadLine();
            var tipoEncontrado = EsNumero(caracterIngresado);
            if (!tipoEncontrado)
            {
                tipoEncontrado= EsVocal(caracterIngresado);

            }
            if (!tipoEncontrado)
            {
                tipoEncontrado = EsLetra(caracterIngresado);

            }
            if (!tipoEncontrado)
            {
                WriteLine("No se encontro el tipo de caracter, puede ser un signo");

            }
            ReadKey();
        }
        public static bool EsNumero(string cadena)
        {
            var bandera = false;
             var caracter = Convert.ToInt32(cadena.ToLower()[0]);
             if (caracter>=48 && caracter<= 57)
             {
                WriteLine("El caracter ingresado es un numero");
                bandera = true;
            }
            
            return bandera;
        }
        public static bool EsVocal(string cadena)
        {
            var bandera = false;
            var caracter = Convert.ToInt32(cadena.ToLower()[0]);
            if (caracter == 97 || caracter == 101 || caracter == 105 || caracter == 111 || caracter == 117)
            {
                WriteLine("El caracter ingresado es una vocal");
                bandera = true;
            }

            return bandera;
        }
        public static bool EsLetra(string cadena)
        {
            var bandera = false;
            var caracter = Convert.ToInt32(cadena.ToLower()[0]);
            if(caracter>= 97 && caracter <= 122)
            {
                if (caracter != 97 && caracter != 101 && caracter != 105 && caracter != 111 && caracter != 117)
                {
                    WriteLine("El caracter ingresado es una letra");
                    bandera = true;
                }
            }
            return bandera;
        }
    }
}
