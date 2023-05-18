namespace Inciso6;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Que tipo de animal es: ");
        var tipo = Console.ReadLine();

        Console.WriteLine("Que color de pelo tiene: ");
        var colorPelo = Console.ReadLine();

        Console.WriteLine("Es domestico (si/no): ");
        var domestico = Console.ReadLine();

        Console.WriteLine("cuantas patas tiene: ");
        var cantPatas = Convert.ToInt32(Console.ReadLine());

        var esDomestico = false;
        if (domestico.ToLower().Contains("si")) { esDomestico = true; }

        Animal animal = new Animal(tipo, colorPelo, esDomestico, cantPatas);


        Console.WriteLine($"{animal.tipo} - {animal.colorPelo} - Es domestico: {animal.domestico} - {animal.numeroPatas} patas");
        Console.ReadKey();

    }
}

