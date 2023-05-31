using System;
using static System.Console;

namespace Inciso1;
class Program
{
    static async Task Main(string[] args)
    {
        WriteLine("Iniciando la receta!");

        Receta receta = new Receta();
        await PrepararParaMezclaPapasyHuevos(receta);
        var mezclarPapasYHuevos =  receta.MezclarPapasYHuevos();
        await Task.WhenAll(mezclarPapasYHuevos);
        var cocinarTortilla = await receta.CocinarTortilla();
        if (cocinarTortilla)
        {
            WriteLine("La receta esta lista!");
        }
        
        ReadKey();
    }
    public static async Task PrepararParaMezclaPapasyHuevos(Receta receta)
    {
        var pelarPapas = receta.PelarPapas();
        var cortarPapas = receta.CortarPapas();
        var batirHuevos = receta.BatirHuevos();
        await Task.WhenAll(pelarPapas, cortarPapas, batirHuevos);
    }
}

