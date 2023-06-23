using System;
namespace RetoSemanal
{
	public interface IListadoVuelos
	{
		public void AgregarVuelo(Vuelo vuelo); // agregar vuelos al listado
		public void Imprimir(); // imprimir todos los vuelos de la lista
		public void Guardar(Conexion conn); // guardar todos los vuelos de la lista en la bd
    }
}

