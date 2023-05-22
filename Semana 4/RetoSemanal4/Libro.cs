using System;
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
                Console.WriteLine("Exito", Titulo);
                Disponible = false;
            }
            else
            {
                Console.WriteLine("No está disponible para préstamo.", Titulo);
            }
        }

        public void Devolver()
        {
            Console.WriteLine("Ha sido devuelto.", Titulo);
            Disponible = true;
        }
    }
}

