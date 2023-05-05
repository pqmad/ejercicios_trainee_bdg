using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Inciso3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("Ingrese cantidad: ");
            var cantidadIngresada = Convert.ToDouble( ReadLine());
            WriteLine("-----------------------------------------------------------");
            CantidadBilletes(ref cantidadIngresada);
            CantidadMonedas(cantidadIngresada);
            WriteLine("-----------------------------------------------------------");
            ReadKey();
        }
        public static void CantidadBilletes(ref double dinero)
        {
            int[] valorBillete = { 5, 10, 20, 50, 100, 200 };
            for (int i = valorBillete.Length-1; i>=0 ; i--)
            {
                var cantidad = Convert.ToInt32(dinero)/ valorBillete[i]; 
                dinero-= valorBillete[i] * cantidad;
                if (cantidad != 0)
                {
                    WriteLine(cantidad + " billetes de Q." + valorBillete[i]+"       -> Queda pendiente: Q."+dinero);
                }
            }
        }
        public static void CantidadMonedas(double dinero)
        {
            double[] valorMoneda = { 0.05, 0.10, 0.50,1.00 };
            for (int i = valorMoneda.Length - 1; i >= 0; i--)
            {
                var cantidad = Convert.ToInt32(dinero / valorMoneda[i]) ;
                dinero -= valorMoneda[i] * cantidad;
                if (cantidad != 0)
                {
                    WriteLine(cantidad + " monedas de Q." + valorMoneda[i] + "       -> Queda pendiente: Q." + dinero);
                }
            }
        }
    }
}
