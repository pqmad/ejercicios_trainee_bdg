using System;
namespace Inciso3
{
	public class Avion : Vehiculo
	{
		public Avion()
		{
		}

		public override void Desplazar()
		{
            Console.WriteLine("El Avion se está desplazando por aire.");
        }

        public override void Desplazar(int metros)
        {
            Console.WriteLine($"El Avion se está desplazando {metros} metros por aire.");
        }

        public override void Desplazar(string destino)
        {
            Console.WriteLine($"El Avion se está desplazando a {destino} por aire.");
        }
    }
}

