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

        public override void Saludo(string soy)
        {
            Console.WriteLine($"Hola! soy un {soy}");
        }

    }
}

