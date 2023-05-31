using System;
using System.Text.Json.Nodes;

namespace Inciso1
{
    public class Receta
    {
        public Receta()
        {
        }
        public async Task PelarPapas()
        {
            await Task.Delay(1000);
            Console.WriteLine("Papas peladas.");
        }
        public async Task CortarPapas()
        {
            await Task.Delay(2000);
            Console.WriteLine("Papas cortadas.");
        }

        public async Task BatirHuevos()
        {
            await Task.Delay(1500);
            Console.WriteLine("Huevos batidos.");
        }

        public async Task MezclarPapasYHuevos()
        {
            await Task.Delay(1000);
            Console.WriteLine("Papas y huevos mezclados.");
        }

        public async Task<bool> CocinarTortilla()
        {
            await Task.Delay(3000);
            Console.WriteLine("Se cocinó las tortillas");
            return true;
        }
    }
}

