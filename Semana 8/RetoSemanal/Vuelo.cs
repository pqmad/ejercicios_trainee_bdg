using System;
namespace RetoSemanal
{
	public class Vuelo
	{
		public int id { get; private set; }
        public string origen { get; private set; }
        public string destino { get; private set; }
        public DateTime fecha { get; private set; }
        public string aereopuerto { get; private set; }
        public string precio { get; private set; }

        public Vuelo(int id, string origen,
			string destino, DateTime fecha, string aereopuerto, string precio)
		{
			this.id = id;
			this.origen = origen;
			this.destino = destino;
			this.fecha = fecha;
			this.aereopuerto = aereopuerto;
			this.precio = precio;
		}
	}
}

