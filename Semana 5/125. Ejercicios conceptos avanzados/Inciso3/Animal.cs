using System;
namespace Inciso3
{
	public class Animal
	{
		public string tipoAnimal { get; private set; } 
		public Animal()
		{
			tipoAnimal = "Desconocido";
		}

		public void VerificarTipoAnimal(int i)
		{
			switch (i)
			{
				case (int)animales.caballo:
					tipoAnimal="CABALLO";
					break;
                case (int)animales.canario:
                    tipoAnimal = "CANARIO";
                    break;
                case (int)animales.gato:
                    tipoAnimal = "GATO";
                    break;
                case (int)animales.perro:
                    tipoAnimal = "PERRO";
                    break;
				default:
                    tipoAnimal = "(Desconocido)";
                    break;

            }

			Console.WriteLine($"ese valor pertenece al {tipoAnimal}");
        }
	}
}

