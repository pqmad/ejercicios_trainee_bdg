using System;
using System.Runtime.CompilerServices;

namespace RetoSemanal
{
	public interface IConexion
	{
        public ListadoVuelos Consulta(string query);
        public void Agregar(Vuelo info);

    }
}

