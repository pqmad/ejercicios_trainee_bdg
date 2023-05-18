using System;
namespace Inciso1
{
	public class Persona
	{
		public string nombre { get; private set; }
		public int edad { get; private set; }

        public Persona()
		{
			nombre = "";
			edad = 0;
		}
        public Persona(string Nombre, int Edad)
        {
            nombre = Nombre;
            edad = Edad;
        }
    }
}

