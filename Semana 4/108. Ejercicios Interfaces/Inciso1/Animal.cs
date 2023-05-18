using System;
namespace Inciso1
{
	public class Animal:IAnimal
	{
		public Animal()
		{
		}

        public void Andar(string s)
        {
            Console.WriteLine($"{s} esta andando...");
        }

        public bool EsPerro(string s)
        {
            if (s.ToLower().Contains("perro"))
            {
                return true;
            }
            return false;
        }

        public void Saltar(string s)
        {
            Console.WriteLine($"{s} esta saltando...");
        }
    }
}

