using System;


namespace Inciso3;
class Program
{
    static void Main(string[] args)
    {
        var valor = 0;
        Animal animal = new Animal();
        do
        {
            Console.WriteLine("Ingresa número");
            valor = Convert.ToInt32(Console.ReadLine());
            if(valor!=0) animal.VerificarTipoAnimal(valor);

        } while (valor != 0);

        Console.ReadKey();
    }
}

