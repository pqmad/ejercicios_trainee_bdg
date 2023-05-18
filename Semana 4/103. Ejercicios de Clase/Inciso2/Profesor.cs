using System;
namespace Inciso2
{
	public class Profesor:Persona
	{
        public string materia { get; set; }
        public Profesor()
        {
            nombre = "";
            materia = "";
            edad = 0;
        }
        public Profesor(string Nombre, int Edad, string Materia)
        {
            nombre = Nombre;
            edad = Edad;
            materia = Materia;
        }
    }
}

