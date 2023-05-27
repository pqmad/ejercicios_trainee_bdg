using System;
using static System.Console;


namespace Inciso1
{
	public class Persona:IPersona
	{
        public string nombre { get; private set; }
        public int edad { get; private set; }
        public string localidad { get; private set; }

        public Persona()
		{
            nombre = "";
            edad = 0;
            localidad = "";
		}

        public Persona(string Nombre, int Edad, string Localidad)
        {
            nombre = Nombre.Trim();
            edad = Edad;
            localidad = Localidad.Trim();
        }

        public string CrearCadena()
        {
            return $"{nombre}|{edad}|{localidad};";
        }

        public void InformacionAlmacenada()
        {
            WriteLine($"{nombre} - {edad} años - {localidad}");
        }
    }
}

