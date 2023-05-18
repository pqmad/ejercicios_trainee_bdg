namespace Inciso3;
class Program
{
    static void Main(string[] args)
    {
        Avion avion = new Avion();
        avion.Desplazar();
        avion.Desplazar(4);
        avion.Desplazar("Guatemala");

        Coche coche = new Coche();
        coche.Desplazar();
        coche.Desplazar(4);
        coche.Desplazar("Guatemala");

        Barco barco = new Barco();
        barco.Desplazar();
        barco.Desplazar(4);
        barco.Desplazar("Guatemala");

        Console.ReadKey();
    }
}

