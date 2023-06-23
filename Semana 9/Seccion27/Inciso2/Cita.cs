using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Inciso2
{
    public class Cita
    {
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public Contacto Persona { get; set; }
        private static string ruta = "agenda.txt";

        public Cita()
        {
            this.Fecha = DateTime.Now;
            this.Descripcion = "";
            this.Persona = new Contacto();
        }

        public Cita(DateTime fecha, string descripcion, Contacto contactoSeleccionado)
        {
            this.Fecha = fecha;
            this.Descripcion = descripcion;
            this.Persona = contactoSeleccionado;
        }

        public void Guardar()
        {
            Conexion conexion = new Conexion();
            conexion.AgregarCita(new Cita(Fecha, Descripcion, Persona));
        }

        public List<Cita> Cargar()
        {
            Conexion conexion = new Conexion();
            return conexion.ConsultaCita("SELECT * from CITA");
        }
    }
}

