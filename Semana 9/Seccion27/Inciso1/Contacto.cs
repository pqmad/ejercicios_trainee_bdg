using System;
using System.Collections.Generic;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Inciso1
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

        public List<Contacto> Cargar()
        {
            List<Contacto> lista = new List<Contacto> { };
            var texto = Archivo.LeerArchivo(ruta);
            var contactos = texto.Split("///");
            foreach (var contacto in contactos)
            {
                var datos= contacto.Split("??");
                if (datos.Length == 4)
                {
                    Contacto c = new Contacto();
                    c.Nombre = datos[0];
                    c.Apellidos = datos[1];
                    c.Telefono = datos[2];
                    c.Localidad = datos[3];
                    lista.Add(c);
                }
                
            }
            return lista;
        }

        public void Guardar()
        {
            var texto = $"{Nombre}??{Apellidos}??{Telefono}??{Localidad}";
            Archivo.GuardarArchivo(ruta, texto);
        }


    }
}

