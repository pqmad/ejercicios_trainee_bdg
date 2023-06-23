namespace RetoSemanal;
using static System.Console;


class Program
{
    static void Main(string[] args)
    {
        Conexion conn = new Conexion();
        var opcion = "0";
        while (!opcion.Contains("4"))
        {
            WriteLine("1. Cargar datos");
            WriteLine("2. Buscar por origen");
            WriteLine("3. Buscar por destino");
            WriteLine("4. Salir");
            WriteLine("Ingrese la opción deseada: ");
            opcion = ReadLine();
            switch (opcion)
            {
                case "1":
                    ListadoVuelos vuelos = Archivo.CargarArchivo();
                    vuelos.Guardar(conn);
                    break;
                case "2":
                    WriteLine("Ingrese el origen a buscar: ");
                    string origen = ReadLine();
                    conn.Consulta($"Select * from RETOSEMANAL where UPPER(origen)='{origen.ToUpper()}'").Imprimir();
                    break;
                case "3":
                    WriteLine("Ingrese el destino a buscar: ");
                    string destino = ReadLine();
                    conn.Consulta($"Select * from RETOSEMANAL where UPPER(destino)='{destino.ToUpper()}'").Imprimir();
                    break;
                case "4":
                    break;
                default:
                    WriteLine("Opción inválida. Inténtelo nuevamente.");
                    break;
            }

        }
    }
}

