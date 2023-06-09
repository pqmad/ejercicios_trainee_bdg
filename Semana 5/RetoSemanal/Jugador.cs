using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace RetoSemanal
{
    [Serializable]
	public class Jugador
	{
		public string nombre    { get; private set; }
        public int nivel        { get; set; }
        public int puntosVida   { get; set; }
        public int muertes      { get; set; }

        public Jugador()
		{
            this.nombre = "Jugador Desconocido";
            this.nivel = 0;
            this.puntosVida = 0;
            this.muertes = 0;
		}

        public Jugador( string nombre)
        {
            this.nombre = nombre;
            this.nivel = 1;
            this.puntosVida = 1;
            this.muertes = 0;
        }

        public void GuardarDatos(string rutaArchivo)
        {
            try
            {
                using (FileStream archivo = File.OpenWrite(rutaArchivo))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(archivo, this);
                }
                var cadena = rutaArchivo + "/";
                var ruta = "jugadores.txt";
                FileStream archivojugadores;
                if (File.Exists(ruta))
                    {
                    archivojugadores = new FileStream(ruta, FileMode.Append);
                    }
                else
                    {
                    archivojugadores = new FileStream(ruta, FileMode.Create);
                    }
                archivojugadores.Write(ASCIIEncoding.ASCII.GetBytes(cadena), 0, cadena.Length);
                archivojugadores.Close();
                
                Console.WriteLine("Los datos se han GUARDADO correctamente.");
            }
            catch (Exception ex)
            {
                RegistrarError(ex, "Error al guardar los datos: ");
            }
        }

        public static Jugador CargarDatos(string rutaArchivo)
        {
            Jugador jugador = new Jugador();
            try
            {
                using (FileStream archivo = File.OpenRead(rutaArchivo))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    jugador = (Jugador)formatter.Deserialize(archivo);
                }
                Console.WriteLine("Los datos se han CARGADO correctamente.");
            }
            catch (Exception ex)
            {
                RegistrarError(ex, "Error al cargar los datos: ");
            }
            return jugador;
        }

        private static void RegistrarError(Exception ex, String mensaje)
        {
            Console.WriteLine(mensaje + ex.Message);
            string mensajeError = $"\n{DateTime.Now}: {ex.Message}";
            File.AppendAllText("errores.log", mensajeError);
        }
    }
}

