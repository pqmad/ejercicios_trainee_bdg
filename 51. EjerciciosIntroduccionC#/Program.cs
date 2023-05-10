using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _51_EjerciciosIntroduccionC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region inciso 1
            WriteLine("\n----------------------------------INCISO 1----------------------------------\n");
            var numero1 = 12;
            var numero2 = 43;
            var numero3 = 10;
            var resultadoTresVariables = numero1 + numero2 + numero3;
            WriteLine("-> " + numero1 + " + " + numero2 + "+ " + numero3 + " = " + resultadoTresVariables);
            #endregion

            #region inciso 2
            WriteLine("\n----------------------------------INCISO 2----------------------------------\n");
            WriteLine("Ingrese un numero:");
            var numeroIngresado1 = ReadLine();
            WriteLine("Ingrese un numero:");
            var numeroIngresado2 = ReadLine();
            var numeroMayor = Convert.ToInt32(numeroIngresado1);
            if (Convert.ToInt32(numeroIngresado1) < Convert.ToInt32(numeroIngresado2))
            {
                numeroMayor = Convert.ToInt32(numeroIngresado2);
            }
            WriteLine("El numero mayor es: " + numeroMayor);
            #endregion

            #region inciso 3
            WriteLine("\n----------------------------------INCISO 3----------------------------------\n");
            WriteLine("Ingrese un dia de la semana:");
            var diaSemanaIngresado = ReadLine();
            string[] arrayDiasEntreSemana = { "lunes", "martes", "miercoles", "jueves", "viernes" };
            var bandera = false;
            foreach (var dia in arrayDiasEntreSemana)
            {
                if (diaSemanaIngresado.ToLower() == dia)
                {
                    bandera = true;
                }
            }
            if (bandera)
            {
                WriteLine(diaSemanaIngresado + " Es ENTRE de semana");
            }
            else
            {
                string[] arrayDiasFinSemana = { "domingo", "sabado" };
                var esFinDeSemana = false;
                foreach (var dia in arrayDiasFinSemana)
                {
                    if (diaSemanaIngresado.ToLower() == dia)
                    {
                        esFinDeSemana = true;
                    }
                }
                if (esFinDeSemana)
                {
                    WriteLine(diaSemanaIngresado + " Es FIN de semana");
                }
                else
                {
                    WriteLine("ERROR al escribir el dia, verifica y escribelo sin tildes");
                }
            }
            #endregion

            #region inciso 4
            WriteLine("\n----------------------------------INCISO 4----------------------------------\n");
            var precioProducto = "";
            var siguePidiendoPrecio = true;
            while (siguePidiendoPrecio)
            {
                WriteLine("Ingrese precio de un producto:");
                precioProducto = ReadLine();
                if (Convert.ToDouble(precioProducto) > 0)
                {
                    siguePidiendoPrecio = false;
                }
            }

            var siguePidiendoMetodo = true;
            var metodoPago = "";
            while (siguePidiendoMetodo)
            {
                WriteLine("Ingrese \"E\" si el pago lo hará en efectivo y \"T\" si el pago lo hará con tarjeta");
                metodoPago = ReadLine();
                if (metodoPago.ToLower() == "e" || metodoPago.ToLower() == "t")
                {
                    siguePidiendoMetodo = false;
                }
            }
            var numeroTarjeta = "";
            if (metodoPago.ToLower() == "t")
            {
                WriteLine("Ingrese el numero de tarjeta:");
                numeroTarjeta = ReadLine();
                WriteLine("\n\nNumero de tarjeta" + numeroTarjeta);
            }
            WriteLine("\nTotal a pagar: " + precioProducto);
            WriteLine("Metodo de pago: " + metodoPago);
            WriteLine("Su compra se realizo con exito!");

            #endregion

            #region inciso 5
            WriteLine("\n----------------------------------INCISO 5----------------------------------\n");
            for (int i = 1; i <= 100; i++)
            {
                Write(i + "  ");

            }
            #endregion

            #region inciso 6
            WriteLine("\n----------------------------------INCISO 6----------------------------------\n");
            var numeroInciso6 = 1;
            while (numeroInciso6 <= 100)
            {
                Write(numeroInciso6 + "  ");
                numeroInciso6++;
            }
            #endregion

            #region inciso 7
            WriteLine("\n----------------------------------INCISO 7----------------------------------\n");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Write(i + "  ");
                }

            }

            #endregion

            #region inciso 8
            WriteLine("\n----------------------------------INCISO 8----------------------------------\n");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Write(i + "  ");
                }

            }
            #endregion

            #region inciso 9
            WriteLine("\n----------------------------------INCISO 9----------------------------------\n");
            int[] arrayNumerosPares = new int[50];
            var numeroInciso9 = 2;
            for (int i = 0; i < arrayNumerosPares.Length; i++)
            {
                arrayNumerosPares[i] = numeroInciso9;
                numeroInciso9 = numeroInciso9 + 2;

            }
            Write("[  ");
            for (int i = 0; i < arrayNumerosPares.Length; i++)
            {
                Write(arrayNumerosPares[(int)i] + "  ");

            }
            WriteLine("]");
            #endregion

            #region inciso 10
            WriteLine("\n----------------------------------INCISO 10---------------------------------\n");
            WriteLine("Ingrese 10 numeros para luego sumarlos...");
            var resultadoSumaInciso10 = 0.0;
            var cantidad = 1;
            while (cantidad <= 10)
            {
                Write("\n" + cantidad + "-----> ");
                var numeroIngresadoInciso10 = ReadLine();
                resultadoSumaInciso10 += Convert.ToDouble(numeroIngresadoInciso10);
                cantidad++;
            }
            WriteLine("El resultado es: " + resultadoSumaInciso10);
            #endregion

            #region inciso 11
            WriteLine("\n----------------------------------INCISO 11---------------------------------\n");
            var siguePidiendo = true;
            var numeroIngresadoInciso11Entero = 0;
            while (siguePidiendo)
            {
                WriteLine("Ingrese un numeros del 1 al 7");
                var numeroIngresadoInciso11 = ReadLine();
                numeroIngresadoInciso11Entero = Convert.ToInt32(numeroIngresadoInciso11);
                if (numeroIngresadoInciso11Entero >= 1 && numeroIngresadoInciso11Entero <= 7)
                {
                    siguePidiendo = false;
                }
            }
            var diaSemanaInciso11 = "";
            switch (numeroIngresadoInciso11Entero)
            {
                case 1:
                    diaSemanaInciso11 = "Lunes";
                    break;
                case 2:
                    diaSemanaInciso11 = "Martes";
                    break;
                case 3:
                    diaSemanaInciso11 = "Miercoles";
                    break;
                case 4:
                    diaSemanaInciso11 = "Jueves";
                    break;
                case 5:
                    diaSemanaInciso11 = "Viernes";
                    break;
                case 6:
                    diaSemanaInciso11 = "Sabado";
                    break;
                case 7:
                    diaSemanaInciso11 = "Domingo";
                    break;
                default:
                    diaSemanaInciso11 = "";
                    break;
            }
            WriteLine("El dia es: " + diaSemanaInciso11);
            #endregion

            #region inciso 12
            WriteLine("\n----------------------------------INCISO 12---------------------------------\n");
            siguePidiendo = true;
            var numeroIngresadoInciso12Entero = 0;
            while (siguePidiendo)
            {
                WriteLine("Ingrese un numeros del 1 al 1000");
                var numeroIngresadoInciso12 = ReadLine();
                numeroIngresadoInciso12Entero = Convert.ToInt32(numeroIngresadoInciso12);
                if (numeroIngresadoInciso12Entero >= 1 && numeroIngresadoInciso12Entero <= 1000)
                {
                    siguePidiendo = false;
                }
            }
            var sumaNumeroIngresadoInciso12Entero = 0;
            for (int i = 1; i <= numeroIngresadoInciso12Entero; i++)
            {
                sumaNumeroIngresadoInciso12Entero = sumaNumeroIngresadoInciso12Entero + i;
            }
            var mediaNumeroIngresadoInciso12Entero = Convert.ToDouble(sumaNumeroIngresadoInciso12Entero) / Convert.ToDouble(numeroIngresadoInciso12Entero);
            WriteLine("La sumatoria es: " + sumaNumeroIngresadoInciso12Entero);
            WriteLine("La media es: " + mediaNumeroIngresadoInciso12Entero);

            #endregion

            #region inciso 13
            WriteLine("\n----------------------------------INCISO 13---------------------------------\n");
            WriteLine("Ingrese un numero:");
            var numeroIngresadoInciso13 = ReadLine();
            var numeroIngresadoInciso13Double = Convert.ToDouble(numeroIngresadoInciso13);

            var esPrimo = true;
            for (int i = 2; i < numeroIngresadoInciso13Double; i++)
            {
                if ((numeroIngresadoInciso13Double % i) == 0)
                {
                    esPrimo = false;
                }
            }
            if (esPrimo)
            {
                WriteLine("El " + numeroIngresadoInciso13Double + " es primo");
            }
            else
            {
                WriteLine("El " + numeroIngresadoInciso13Double + " no es primo");
            }
            #endregion


            #region inciso 14
            WriteLine("\n----------------------------------INCISO 14---------------------------------\n");
            WriteLine("Ingrese un numero:");
            var numeroIngresadoInciso14 = ReadLine();
            var numeroIngresadoInciso14Int = Convert.ToInt32(numeroIngresadoInciso14);

            var cantidadCifras = 0;
            do
            {
                numeroIngresadoInciso14Int = numeroIngresadoInciso14Int / 10;
                cantidadCifras++;
            } while (numeroIngresadoInciso14Int > 0);

            WriteLine("El numero: " + numeroIngresadoInciso14 + " tiene " + cantidadCifras + " cifras.");
            #endregion

            ReadKey();
            
        }
    }
}
