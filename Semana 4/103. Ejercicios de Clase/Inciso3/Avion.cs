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

        public override void Saludo(string soy)
        {
            Console.WriteLine($"Hola! soy un {soy}");
        }

    }
}

