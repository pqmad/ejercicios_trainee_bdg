using System;
using static System.Console;


namespace RetoSemanal4
{
	public class Libro:Material
	{
        public string Autor { get; set; }

        public Libro(string titulo, bool disponible, string autor) : base(titulo, disponible)
        {
            Autor = autor;
        }

        public void Prestar()
        {
            if (Disponible)
            {
                Disponible = false;
                WriteLine($"Se PRESTO el {Titulo} con exito");
                return;
            }
            WriteLine($"NO se presto el {Titulo}");
        }

        public void Devolver()
        {
            if (!Disponible)
            {
                Disponible = true;
                WriteLine($"Se DEVOLVIO el {Titulo} con exito");
                return;
            }
            WriteLine($"NO se devolvio el {Titulo}");
        }
    }
}

