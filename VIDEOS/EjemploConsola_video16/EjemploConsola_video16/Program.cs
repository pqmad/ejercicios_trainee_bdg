using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploConsola_video16
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Se puede consumir apps de terceros

            OPCION 1
            click derecho en el proyecto, agregar, referencia, buscar el archivo dll deseado y añadir
            luego ya se puede empezar a llamar 
            
            OPCION 2
            click derecho en el proyecto, Admin paquetes NuGet, Buscar, instalar y compilar

            Como usar (es como la importaciones)

                    var saludo = new Saludo();
                    Console.WriteLine(saludo.Saludar("Ariana"));

             */

            Console.WriteLine("Holis");
            Console.Read(); // esperar a que teclee algo para seguir

            var mensaje = "Hola";
            Console.WriteLine(mensaje);
            mensaje=Console.ReadLine();//obtener lo ingresado en consola

            Console.WriteLine(mensaje);
            //Console.Read();
        }
    }
}
