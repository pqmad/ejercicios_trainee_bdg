using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Inciso1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var opcionElegida = 0;
            while (opcionElegida!=3)
            {
                WriteLine("________________________________________________________________");
                
                WriteLine("\nElige una opción: \n");
                WriteLine("1) Dolar a Euro");
                WriteLine("2) Euro a dolar");
                WriteLine("3) Salir");
                opcionElegida =Convert.ToInt32(ReadLine());
                if (opcionElegida != 3)
                {
                    WriteLine("Ingresa cambio del día (1 dolar equivale a _____ euros):");
                    var tipoCambio = ReadLine();
                    WriteLine("Ingresa la cantidad de euros o dolares:");
                    var moneda = ReadLine();


                    switch (opcionElegida)
                    {
                        case 1:
                            CambioDolarEuro(Convert.ToDouble(tipoCambio), Convert.ToDouble(moneda));
                            break;
                        case 2:
                            CambioEuroDolar(Convert.ToDouble(tipoCambio), Convert.ToDouble(moneda));
                            break;
                        default:
                            break;
                    }
                }
               
            }
        }
        public static void CambioEuroDolar(double cambio, double cantidad)
        {
            var dolares = cantidad / cambio;
            WriteLine(cantidad + " de Euros equivalen a " + dolares + " dolareas");
        }
        public static void CambioDolarEuro(double cambio, double cantidad)
        {
            var euros = cantidad * cambio;
            WriteLine(cantidad + " de dolares equivalen a " + euros + " euros");
        }
    }
}
