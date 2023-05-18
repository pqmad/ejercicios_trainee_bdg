namespace Inciso1;
class Program
{
    static void Main(string[] args)
    {
        List<string> listadoAnimal = new List<string> { "gato", "perro", "perico" };

        foreach (var animal in listadoAnimal)
        {
            Animal mascota = new Animal();
            if (mascota.EsPerro(animal))
            {
                Console.WriteLine("\n\nEste animal es un perro");
            }
            else
            {
                Console.WriteLine("\n\nEste animal NO es un perro");
            }
            mascota.Andar(animal);
            mascota.Saltar(animal);
        }
        Console.ReadKey();
        
    }
}

