using System;
using static System.Console;

namespace RetoSemanal4;

class Program
{
    static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();
        LlenarBiblioteca_Libros(ref biblioteca);
        LlenarBiblioteca_Revistas(ref biblioteca);

        ImprimirListado(biblioteca.ListadoBiblioteca);

        var resultadosBusqueda = biblioteca.BuscarPorTitulo("vista");
        ImprimirListado(resultadosBusqueda);

        if (biblioteca.PrestarMaterial(new Libro($"Libro0", true, $"Autor0")))
        {
            WriteLine("Se PRESTO el item con exito");
        }
        else
        {
            WriteLine("NO se presto el item");
        }

        resultadosBusqueda = biblioteca.BuscarPorTitulo("0");
        ImprimirListado(resultadosBusqueda);

        if (biblioteca.DevolverMaterial(new Libro($"Libro0", true, $"Autor0")))
        {
            WriteLine("Se DEVOLVIO el item con exito");
        }
        else
        {
            WriteLine("NO se devolvio el item");
        }

        resultadosBusqueda = biblioteca.BuscarPorTitulo("0");
        ImprimirListado(resultadosBusqueda);

        ReadKey();

    }
    public static void ImprimirListado(List<Material> listado)
    {
        WriteLine("\n\nRESULTADOS DE BUSQUEDA\n");
        foreach (var item in listado)
        {
            var estado = "No Disponible";
            if (item.Disponible) estado = "Disponible";

            WriteLine(item.Titulo + " - " + estado);
        }

        WriteLine("\n\n\n");
    }

    public static void LlenarBiblioteca_Libros(ref Biblioteca biblioteca)
    {
        var cantidad = 0;
        while (cantidad < 5)
        {
            Libro libro = new Libro($"Libro{cantidad}", true, $"Autor{cantidad}");
            biblioteca.AgregarMaterial(libro);
            WriteLine("Se agrego item a la biblioteca");
            cantidad++;
        }
    }

    public static void LlenarBiblioteca_Revistas(ref Biblioteca biblioteca)
    {
        var cantidad = 0;
        while (cantidad < 5)
        {
            Revista revista = new Revista($"Revista{cantidad}", true, $"Edicion 00{cantidad}");
            biblioteca.AgregarMaterial(revista);
            WriteLine("Se agrego item a la biblioteca");
            cantidad++;
        }
    }
}

