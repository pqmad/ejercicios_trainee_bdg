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

        public override void Saludo(string soy)
        {
            Console.WriteLine($"Hola! soy un {soy}");
        }

    }
}

