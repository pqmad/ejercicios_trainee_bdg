using System;
namespace Inciso2
{
	public class Persona
	{
		public string nombre { get; set; }
		public int edad { get; set; }

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

