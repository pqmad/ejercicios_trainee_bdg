using System;
namespace Inciso6
{
	public class Animal
	{
		public string tipo { get; private set; }
        public string colorPelo { get; private set; }
        public bool domestico { get; private set; }
        public int numeroPatas { get; private set; }

        public Animal()
		{
			tipo = "";
			colorPelo = "";
			domestico = false;
			numeroPatas = 0;
		}
        public Animal(string Tipo, string ColorPelo, bool Domestico, int Patas)
        {
            tipo = Tipo;
            colorPelo = ColorPelo;
            domestico = Domestico;
            numeroPatas = Patas;
        }
    }
}

