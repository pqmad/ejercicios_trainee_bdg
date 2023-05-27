using System;
using static System.Console;


namespace Inciso2;
class Program
{
    static void Main(string[] args)
    {

        Cadenas();
        Enteros();
        Decimales();

        ReadKey();
    }

    private static void Cadenas() {
        var cantidad = 0;
        Generica<string> listaGenerica = new Generica<string>();
        while (cantidad < 5)
        {
            WriteLine("Ingresa una cadena");
            var ingresado = ReadLine();
            listaGenerica.AgregarItem(ingresado);
            cantidad++;
        }
        listaGenerica.ImprimirLista();
    }

    private static void Enteros()
    {
        var cantidad = 0;
        Generica<Int32> listaGenerica = new Generica<Int32>();
        while (cantidad < 5)
        {
            WriteLine("Ingresa un numero entero");
            var ingresado = Convert.ToInt32(ReadLine());
            listaGenerica.AgregarItem(ingresado);
            cantidad++;
        }
        listaGenerica.ImprimirLista();
    }

    private static void Decimales()
    {
        var cantidad = 0;
        Generica<double> listaGenerica = new Generica<double>();
        while (cantidad < 5)
        {
            WriteLine("Ingresa un numero decimal");
            var ingresado = Convert.ToDouble(ReadLine());
            listaGenerica.AgregarItem(ingresado);
            cantidad++;
        }
        listaGenerica.ImprimirLista();
    }
}

