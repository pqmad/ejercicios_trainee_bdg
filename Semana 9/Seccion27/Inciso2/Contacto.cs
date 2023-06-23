using System;
using System.Collections.Generic;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Inciso2
{
    public class Contacto
    {
        public string Nombre { get; private set; }
        public string Apellidos { get; private set; }
        public string Telefono { get; private set; }
        public string Localidad { get; private set; }

        private static string ruta = "contactos.txt";

        public Contacto()
        {
            this.Nombre = "";
            this.Apellidos = "";
            this.Telefono = "";
            this.Localidad = "";
        }
        public Contacto(string nombre, string apellido, string tel, string localidad)
        {
            this.Nombre = nombre;
            this.Apellidos = apellido;
            this.Telefono = tel;
            this.Localidad = localidad;
        }
        public void Guardar()
        {
            Conexion conexion = new Conexion();
            conexion.AgregarContacto(new Contacto(
                Nombre, Apellidos, Telefono, Localidad
                ));
        }

        public List<Contacto> Cargar()
        {
            Conexion conexion = new Conexion();
            return conexion.ConsultaContacto("SELECT * from CONTACTO");
        }


    }
}

