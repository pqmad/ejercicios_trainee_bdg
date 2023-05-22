using System;
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
                Console.WriteLine("Exito", Titulo);
                Disponible = false;
            }
            else
            {
                Console.WriteLine("No está disponible para préstamo.", Titulo);
            }
        }
    }
}

