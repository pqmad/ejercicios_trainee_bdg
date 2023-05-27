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

        //Todos los libros y revistas agregadas anteriormente
        ImprimirListado(biblioteca.ListadoBiblioteca, "listado de biblioteca");

        //Verificar busqueda titulos que contengan "vista"
        var palabraBuscar = "vista";
        var resultadosBusqueda = biblioteca.BuscarPorTitulo(palabraBuscar);
        ImprimirListado(resultadosBusqueda, $"busqueda de \"{palabraBuscar}\"");

        //Prestar un libro
        biblioteca.PrestarMaterial(new Libro($"Libro0", true, $"Autor0"));
        biblioteca.PrestarMaterial(new Revista($"Revista1", true, $"Edicion 001"));
        biblioteca.PrestarMaterial(new Libro($"Libro3", true, $"Autor3"));
        biblioteca.PrestarMaterial(new Revista($"Revista4", true, $"Edicion 004"));




        biblioteca.DevolverMaterial(new Libro($"Libro0", true, $"Autor0"));
        biblioteca.DevolverMaterial(new Revista($"Revista4", true, $"Edicion 004"));

        ImprimirListado(biblioteca.ListadoBiblioteca, "listado de biblioteca");

        ReadKey();

    }
    public static void ImprimirListado(List<Material> listado, string titulo)
    {
        WriteLine("\n-------------------------------------------------");
        WriteLine(titulo.ToUpper()+ "\n");
        foreach (var item in listado)
        {
            var estado = "No Disponible";
            if (item.Disponible) estado = "Disponible";

            if (item.GetType() == typeof(Libro))
            {
                Libro libro = (Libro)item;
                WriteLine(libro.Titulo + " - " + estado+ " - " + libro.Autor);
            }
            else if (item.GetType() == typeof(Revista))
            {
                Revista revista= (Revista)item;
                WriteLine(revista.Titulo + " - " + estado + " - " + revista.Edicion);
            }
           

        }
        WriteLine("\n-------------------------------------------------\n");
    }

    public static void LlenarBiblioteca_Libros(ref Biblioteca biblioteca)
    {
        var cantidad = 0;
        while (cantidad < 5)
        {
            Material libro = new Libro($"Libro{cantidad}", true, $"Autor{cantidad}");
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
            Material revista = new Revista($"Revista{cantidad}", true, $"Edicion 00{cantidad}");
            biblioteca.AgregarMaterial(revista);
            WriteLine("Se agrego item a la biblioteca");
            cantidad++;
        }
    }
}

