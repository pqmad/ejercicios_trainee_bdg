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
        ReadKey();

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

