using System;
namespace Inciso2
{
	public class Alumno:Persona
	{
		public int numeroAlumno { get; set; }
		public Alumno()
		{
			nombre = "";
			numeroAlumno = 0;
			edad = 0;
		}
        public Alumno(string Nombre, int Edad, int Numero)
        {
            nombre = Nombre;
            edad = Edad;
            numeroAlumno = Numero;
        }
	}
}

