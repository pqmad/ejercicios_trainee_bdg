using System;
using static System.Console;

namespace RetoSemanal
{
	public class ListadoVuelos : IListadoVuelos
    {
        public List<Vuelo> Listado { get; private set; }

		public ListadoVuelos()
		{
            Listado = new List<Vuelo> { };
		}

        public void Guardar(Conexion conn) //guardar en la bd
        {
            WriteLine("Espere un momento por favor...");
            foreach (var vuelo in Listado)
            {
                conn.Agregar(vuelo);
                Write(".");
               
            }
            WriteLine($"\nLos vuelos se cargaron a la base de datos correctamente.");
        }

        public void AgregarVuelo(Vuelo vuelo)
        {
            Listado.Add(vuelo);
        }

        public void Imprimir()
        {
            WriteLine("-----------------------------------");
            foreach (var vuelo in Listado)
            {
                WriteLine($"IdVuelo: {vuelo.id}, \n\t\tOrigen: {vuelo.origen}, \n\t\tDestino: {vuelo.destino}, \n\t\tFecha: {vuelo.fecha}, \n\t\tAeropuerto: {vuelo.aereopuerto}, \n\t\tPrecio: {vuelo.precio}");
            }
            WriteLine("-----------------------------------");
        }
    }
}

