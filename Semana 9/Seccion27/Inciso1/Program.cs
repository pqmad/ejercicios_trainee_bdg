namespace Inciso1;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        bool salir = false;
        AgendaManager agenda = new AgendaManager();
        while (!salir)
        {
            WriteLine("***************");
            WriteLine("Agenda");
            WriteLine("***************");
            WriteLine("1 - Añadir cita");
            WriteLine("2 - Añadir contacto");
            WriteLine("3 - Consultar cita");
            WriteLine("4 - Buscar contacto");
            WriteLine("0 - Salir");

            WriteLine("Elige una opción:");
            string opcion = ReadLine();

            switch (opcion)
            {
                case "1":
                    agenda.AgregarCita();
                    break;
                case "2":
                    agenda.AgregarContacto();
                    break;
                case "3":
                    agenda.ConsultarCitas();
                    break;
                case "4":
                    WriteLine("Introduce el nombre del contacto:");
                    string nombre = ReadLine();
                    List<Contacto> contactosEncontrados = agenda.BuscarContactoPorNombre(nombre);

                    if (contactosEncontrados.Count == 0)
                    {
                        WriteLine("No se encontró ningún contacto con ese nombre.");
                        break;
                    }

                    WriteLine("Contactos encontrados:");
                    agenda.MostrarContactos(contactosEncontrados);
                    break;
                case "0":
                    WriteLine("¿Estás seguro de que deseas salir? (S/N)");
                    string confirmacion = ReadLine();

                    if (confirmacion.ToUpper().Contains("S"))
                    {
                        salir = true;
                    }
                    break;
                default:
                    WriteLine("Opción inválida. Vuelve a intentarlo.");
                    break;
            }
        }
    }

}