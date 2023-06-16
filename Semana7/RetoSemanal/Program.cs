using static System.Console;


namespace RetoSemanal;
class Program
{
    

    static async Task Main(string[] args)
    {
        var opcion = "0"; 
        while (!opcion.Contains("3"))
        {
            WriteLine("1. Obtener chiste aleatorio");
            WriteLine("2. Buscar chistes por palabra clave");
            WriteLine("3. Salir");
            WriteLine("Ingrese la opción deseada: ");
            opcion = ReadLine();

            Chiste chiste = new Chiste();
            switch (opcion)
            {
                case "1":
                    await chiste.ObtenerChiste();
                    break;
                case "2":
                    WriteLine("Ingrese la palabra clave: ");
                    string palabraClave = ReadLine();
                    if (!chiste.Busqueda(palabraClave, true))
                    {
                        WriteLine("No se encontro la palabra en ningún chiste");
                    }
                    break;
                case "3":
                    break;
                default:
                    WriteLine("Opción inválida. Inténtelo nuevamente.");
                    break;
            }

        }
    }



    
}

