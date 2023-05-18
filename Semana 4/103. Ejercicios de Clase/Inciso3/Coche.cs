using System;
namespace Inciso3
{
	public class Coche:Vehiculo
	{
		public Coche()
		{
		}

		public override void Desplazar()
		{
            Console.WriteLine("El coche se está desplazando por la carretera.");
        }

        public override void Desplazar(int metros)
        {
            Console.WriteLine($"El coche se está desplazando {metros} metros por la carretera.");
        }

        public override void Desplazar(string destino)
        {
            Console.WriteLine($"El coche se está desplazando a {destino} por la carretera.");
        }

    }
}

