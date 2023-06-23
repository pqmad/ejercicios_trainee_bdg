using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Inciso1
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
            var texto = $"{Fecha}??{Descripcion}??{Persona.Nombre} {Persona.Apellidos}";
            Archivo.GuardarArchivo(ruta, texto);
        }

        public List<Cita> Cargar()
        {
            List<Cita> lista = new List<Cita> { };
            var texto = Archivo.LeerArchivo(ruta);
            var citas = texto.Split("///");
            foreach (var cita in citas)
            {
                var datos = cita.Split("??");
                if (datos.Length == 3)
                {
                    Cita c = new Cita();
                    c.Fecha =Convert.ToDateTime(datos[0]) ;
                    c.Descripcion = datos[1];
                    Contacto contacto = new Contacto();
                    
                    c.Persona = contacto.Cargar().Find(c =>datos[2].ToUpper().Contains($"{c.Nombre.ToUpper()} {c.Apellidos.ToUpper()}"));
                    lista.Add(c);
                }

            }
            return lista;
        }
    }
}

