using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nomenclatura_video36
{
    internal class Program
    {
        private readonly string _estaCadena; // variables privadas usan guión bajo al inicio
        public const string NOMBRE = "Ariana"; // Constantes TODO en Mayuscula
        static void Main(string[] args)
        {

            /*
             * Nomenclatura
             * 
             * Nombres descriptivos para todo
             * 
             * 
             * CAMEL CASE
             * 
             * para variables locales y parametros 
             * (minuscula al principo y Cada inicio de palabra mayuscula luego)
             * 
             * PASCAL
             * 
             * para métodos  (Cada inicio de palabra mayuscula)
             */
            #region variables nomenclatura
            // la region es para agrupar código
            var esUnaVariable = "CAMEL CASE";
            var EsUnMetodoFake = "PASCAL";
            #endregion
        }
        public int SumaDosNúmeros (int numUno, int numDos)
        {
            var resultado = numUno + numDos;
            return resultado;
        }
    }
}
