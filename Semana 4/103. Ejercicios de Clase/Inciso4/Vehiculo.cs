using System;
namespace Inciso4
{
	public class Vehiculo
	{
		private int puertas { get; set; }
        private int ruedas { get; set; }

        public Vehiculo()
		{
			ruedas = 0;
			puertas = 0;
		}

        public Vehiculo(int Ruedas)
        {
            ruedas = Ruedas;
            puertas = 0;
        }

        public Vehiculo(int Ruedas, int Puertas)
        {
            ruedas = Ruedas;
            puertas = Puertas;
        }
    }
}

