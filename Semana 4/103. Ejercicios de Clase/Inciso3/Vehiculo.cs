using System;
using static System.Console;


namespace Inciso3
{
	public abstract class Vehiculo
	{
		public abstract void Desplazar();

		public virtual void Saludo(string soy)
		{
			WriteLine($"Hola! soy un {soy}");
		}
	}
}

