using System;
using System.Diagnostics.Contracts;
using static System.Console;
namespace Inciso2
{
    public class AgendaManager
    {

        public AgendaManager()
        {
        }


        public void AgregarCita()
        {
            WriteLine("Introduce la fecha de la cita (dd/mm/aaaa hh:mm):");
            DateTime fecha;
            if (!DateTime.TryParse(ReadLine(), out fecha))
            {
                WriteLine("Fecha inválida. Vuelve a intentarlo.");
                return;
            }

            WriteLine("Introduce la descripción de la cita:");
            string descripcion = ReadLine();

            WriteLine("Introduce el nombre del contacto:");
            string nombre = ReadLine();
            //cargar contactos y agregarlos a 
            List<Contacto> contactosEncontrados = BuscarContactoPorNombre(nombre);

            if (contactosEncontrados.Count == 0)
            {
                WriteLine("No se encontró ningún contacto con ese nombre. Primero debes agregar el contacto.");
                AgregarContacto();
                return;
            }
            var numContacto = 1;
            foreach (var contacto in contactosEncontrados)
            {
                WriteLine($"{numContacto}) {contacto.Nombre} {contacto.Apellidos}");
                numContacto++;
            }
            WriteLine("Introduce el número del contacto:");
            numContacto = Convert.ToInt32(ReadLine());

            Contacto contactoSeleccionado = contactosEncontrados[numContacto - 1];
            Cita nuevaCita = new Cita(fecha, descripcion, contactoSeleccionado);
            nuevaCita.Guardar();
            WriteLine("Cita agregada exitosamente.");
        }

        public List<Contacto> BuscarContactoPorNombre(string nombre)
        {
            Contacto contacto = new Contacto();
            return contacto.Cargar().FindAll(c => c.Nombre.ToUpper().Contains(nombre.ToUpper()));
        }

        public void AgregarContacto()
        {
            WriteLine("Introduce el nombre del contacto:");
            var nombre = ReadLine();

            WriteLine("Introduce los apellidos del contacto:");
            var Apellidos = ReadLine();

            WriteLine("Introduce el número de teléfono del contacto:");
            var Telefono = ReadLine();

            WriteLine("Introduce la localidad del contacto:");
            var Localidad = ReadLine();

            Contacto nuevoContacto = new Contacto(nombre, Apellidos, Telefono, Localidad);
            MostrarContacto(nuevoContacto);

            WriteLine("¿Deseas guardar el contacto? (S/N)");
            string confirmacion = ReadLine();

            if (confirmacion.ToUpper().Contains("S"))
            {
                nuevoContacto.Guardar();
                WriteLine("Contacto guardado exitosamente.");
            }
            else
            {
                WriteLine("El contacto NO se guardó.");
            }
        }

        public void ConsultarCitas()
        {
            WriteLine("1 - Consultar por fecha");
            WriteLine("2 - Consultar por contacto");

            string opcion = ReadLine();

            switch (opcion)
            {
                case "1":
                    ConsultarCitasPorFecha();
                    break;
                case "2":
                    ConsultarCitasPorContacto();
                    break;
                default:
                    WriteLine("Opción inválida.");
                    break;
            }
        }

        private void ConsultarCitasPorFecha()
        {
            WriteLine("Introduce la fecha (dd/mm/aaaa):");
            DateTime fecha;
            if (!DateTime.TryParse(ReadLine(), out fecha))
            {
                WriteLine("Fecha inválida. Vuelve a intentarlo.");
                return;
            }
            Cita cita = new Cita();
            List<Cita> citasEncontradas = cita.Cargar().FindAll(c => c.Fecha.Date == fecha.Date);

            if (citasEncontradas.Count > 0)
            {
                WriteLine("Citas encontradas:");
                MostrarCitas(citasEncontradas);
            }
            else
            {
                WriteLine("No existen citas para esa fecha.");
            }
        }

        // Método para consultar citas por contacto
        private void ConsultarCitasPorContacto()
        {
            WriteLine("Introduce el nombre del contacto:");
            string nombre = ReadLine();
            List<Contacto> contactosEncontrados = BuscarContactoPorNombre(nombre);

            if (contactosEncontrados.Count == 0)
            {
                WriteLine("No se encontró ningún contacto con ese nombre.");
                return;
            }

            WriteLine("Contactos encontrados:");
            var numContacto = 1;
            foreach (var contacto in contactosEncontrados)
            {
                WriteLine($"{numContacto}) {contacto.Nombre} {contacto.Apellidos}");
                numContacto++;
            }
            WriteLine("Introduce el número del contacto:");
            numContacto = Convert.ToInt32(ReadLine());

            Contacto contactoSeleccionado = contactosEncontrados[numContacto - 1];
            var nombreCompleto = $"{contactoSeleccionado.Nombre} {contactoSeleccionado.Apellidos}";
            Cita cita = new Cita();
            List<Cita> citasEncontradas = cita.Cargar().FindAll(c => nombreCompleto.ToUpper().Contains($"{c.Persona.Nombre.ToUpper()} {c.Persona.Apellidos.ToUpper()}"));

            if (citasEncontradas.Count > 0)
            {
                WriteLine("Citas encontradas:");
                MostrarCitas(citasEncontradas);
            }
            else
            {
                WriteLine("No existen citas para ese contacto.");
            }
        }


        private void MostrarContacto(Contacto contacto)
        {
            WriteLine($"Nombre: {contacto.Nombre}");
            WriteLine($"Apellidos: {contacto.Apellidos}");
            WriteLine($"Teléfono: {contacto.Telefono}");
            WriteLine($"Localidad: {contacto.Localidad}");
        }


        public void MostrarContactos(List<Contacto> contactos)
        {
            WriteLine($"\n**************************************");
            foreach (var contacto in contactos)
            {
                MostrarContacto(contacto);
                WriteLine();
            }
            WriteLine($"**************************************");
        }


        private void MostrarCita(Cita cita)
        {
            WriteLine($"Fecha: {cita.Fecha}");
            WriteLine($"Descripción: {cita.Descripcion}");
            WriteLine("Contacto:");
            MostrarContacto(cita.Persona);
        }


        private void MostrarCitas(List<Cita> citas)
        {
            WriteLine($"\n**************************************");
            foreach (var cita in citas)
            {
                MostrarCita(cita);
                WriteLine();
            }
            WriteLine($"**************************************");
        }


    }
}

