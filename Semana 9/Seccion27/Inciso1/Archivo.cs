using System;
using System.Globalization;
using System.Text;
using static System.Console;

namespace Inciso1
{
	public static class Archivo
	{
		

        public static string LeerArchivo(string ruta)
        {
            try { 
                FileStream archivo;
                byte[] contenido = new byte[10000];

                archivo = new FileStream(ruta, FileMode.Open);
                archivo.Read(contenido, 0, (int)archivo.Length);
                archivo.Close();

                return ASCIIEncoding.ASCII.GetString(contenido);
            }
            catch (Exception ex)
            {
                RegistrarError(ex, "Error al cargar los datos: ");
            }
            return "";
        }

        public static void GuardarArchivo(string ruta, string cadena)
        {
            try
            {
                FileStream archivo;
                cadena = cadena + "///";
                if (File.Exists(ruta))
                {
                    archivo = new FileStream(ruta, FileMode.Append);
                }
                else
                {
                    archivo = new FileStream(ruta, FileMode.Create);
                }
                archivo.Write(ASCIIEncoding.ASCII.GetBytes(cadena), 0, cadena.Length);
                archivo.Close();
            }
            catch (Exception ex)
            {
                RegistrarError(ex, "Error al guardar los datos: ");
            }
        }

        private static void RegistrarError(Exception ex, String mensaje)
        {
            WriteLine(mensaje + ex.Message);
        }
    }
}

