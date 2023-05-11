using System;
using System.Collections;
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
            WriteLine("Canitdad de elementos a ingresar:");
            var cantidadElementos= Convert.ToInt32(ReadLine());
            var cantidadIngresados = 0;
            ArrayList ListadoValores = new ArrayList();
            while (cantidadElementos>cantidadIngresados)
            {
                WriteLine("Ingrese valor");
                ListadoValores.Add(ReadLine());
                cantidadIngresados++;
            }
            PintarArreglo(ListadoValores);
            WriteLine("\nIngrese valor");
            var valor = ReadLine();
            WriteLine("\nIngrese posición");
            var posicion = Convert.ToInt32(ReadLine()) ;
            ListadoValores[posicion] = valor;
            PintarArreglo(ListadoValores);
            ReadKey();
        }
        public static void PintarArreglo(ArrayList listadoValores)
        {
            WriteLine("\n-----------------------------------------------------------------");
            foreach (var item in listadoValores)
            {
                Write(item+"   ");
            }
            WriteLine("\n-----------------------------------------------------------------");
        }
    }
}
