using System;
using static System.Console;

namespace RetoSemanal4
{
	public class Revista:Material
	{
        public string Edicion { get; set; }

        public Revista(string titulo, bool disponible, string edicion) : base(titulo, disponible)
        {
            Edicion = edicion;
        }

        public void Prestar()
        {
            if (Disponible)
            {
                Disponible = false;
                WriteLine($"Se PRESTO la {Titulo} con exito");
                return;
            }
            WriteLine($"NO se presto la {Titulo}");
        }
    }
}

