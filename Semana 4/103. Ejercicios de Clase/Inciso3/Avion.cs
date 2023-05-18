using System;
namespace Inciso3
{
	public class Barco: Vehiculo
	{
		public Barco()
		{
		}

		public override void Desplazar()
		{
            Console.WriteLine("El Barco se está desplazando por agua.");
        }

        public override void Desplazar(int metros)
        {
            Console.WriteLine($"El Barco se está desplazando {metros} metros por agua.");
        }

        public override void Desplazar(string destino)
        {
            Console.WriteLine($"El Barco se está desplazando a {destino} por agua.");
        }
    }
}

