using System;
namespace RetoSemanal4
{
	public abstract class Material
	{
        public string Titulo { get; set; }
        public bool Disponible { get; set; }

        public Material(string titulo, bool disponible)
        {
            Titulo = titulo;
            Disponible = disponible;
        }

    }
}

