namespace Inciso5;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un numero:");
        var num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese un numero:");
        var num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"El resultado es: {Producto.Suma(num1, num2)}");
        Console.ReadKey();
    }
}

