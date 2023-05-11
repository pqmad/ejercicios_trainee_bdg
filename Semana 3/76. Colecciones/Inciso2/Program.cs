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
            List<string> listNombres = new List<string>();
            var cantidad = 0;
            while (cantidad<5)
            {
                WriteLine("Escribir un nombre:");
                listNombres.Add(ReadLine());
                cantidad++;
            }
            WriteLine("\nEscribir un nombre para verificar el listado:");
            var nombreVerificar=ReadLine();
            var siEsta = false;
            WriteLine("----------------------------------------------------------");
            foreach (var item in listNombres)
            {
                Write(item.ToString()+" - ");
                if (item.ToLower() == nombreVerificar.ToLower()) { 
                    siEsta= true;
                    break;
                }

            }
            WriteLine("\n----------------------------------------------------------");
            if (siEsta)
            {
                WriteLine($"{nombreVerificar} SI esta en el listado");
            }
            else
            {
                WriteLine($"{nombreVerificar} NO esta en el listado");
            }
            ReadKey();  
        }
    }
}
