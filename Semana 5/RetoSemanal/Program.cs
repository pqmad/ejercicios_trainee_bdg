using System.Collections.Specialized;
using System.Text;
using static System.Console;


namespace RetoSemanal;
class Program
{
    static void Main(string[] args)
    {
        WriteLine("Bienvenido al juego de aventuras!");

        Random random = new Random(); //numeros random para inicializar jugador

        List<string> listadoJugadores = new List<string>
        { "MadAri","LuisDa", "ErcL98", "IPQP1980" };

        foreach (var nombrejugador in listadoJugadores)
        {
            var ruta = nombrejugador + ".bin";
            //Crear jugador
            Jugador jugador = new Jugador(nombrejugador);
            jugador.nivel = random.Next(1, 30); ;
            jugador.puntosVida = random.Next(1, 1000); ;
            jugador.muertes = random.Next(0, 1000); ;
            jugador.GuardarDatos(ruta);

            //Cargar Datos
            jugador = Jugador.CargarDatos(ruta);
            ImprimirPropiedadesJugador(jugador);

            //Cambiar datos para volverlos a guardar para el usuario
            //Simulando que avanzo en el juego
            jugador.nivel += 1;
            jugador.puntosVida += 25;
            jugador.muertes += 10;
            jugador.GuardarDatos(ruta);
            ImprimirPropiedadesJugador(jugador);
            
        }
        var nombre = "";
        while (!nombre.Equals("0"))
        {
            WriteLine("Busca a un jugador, presiona 0 para salir:");
            nombre = ReadLine().ToLower().Trim();
            if (!nombre.Equals("0"))
            {
                if (!Busqueda(nombre))
                {
                    WriteLine("No se ha encotrado ningun usuario con ese nombre");
                }
                
            }
        }
        
        ReadKey();

    }

    private static bool Busqueda(String nombre)
    {
        var ruta = "jugadores.txt";
        FileStream archivo;
        byte[] contenido = new byte[10000];

        archivo = new FileStream(ruta, FileMode.Open);
        archivo.Read(contenido, 0, (int)archivo.Length);
        archivo.Close();

        var texto = ASCIIEncoding.ASCII.GetString(contenido).Split("/");
        foreach (var usuario in texto)
        {
            if (usuario.ToLower().Contains(nombre))
            {
                Jugador jugador = new Jugador();
                jugador = Jugador.CargarDatos(usuario);
                ImprimirPropiedadesJugador(jugador);
                return true;
            }
        }
        return false;
    }
    private static void ImprimirPropiedadesJugador(Jugador jugadorCargado)
    {
        if (!jugadorCargado.nombre.Equals("Jugador Desconocido"))
        {
            WriteLine("\n-----------------------------------------------");
            WriteLine("DATOS DEL JUGADOR CARGADOS:\n");
            WriteLine("Nombre: " + jugadorCargado.nombre);
            WriteLine("Nivel: " + jugadorCargado.nivel);
            WriteLine("Puntos de vida: " + jugadorCargado.puntosVida);
            WriteLine("Número de muertes: " + jugadorCargado.muertes);
            WriteLine("-----------------------------------------------\n");
        }
    }
}

