using System;
using Microsoft.Data.SqlClient;
using static System.Console;

namespace RetoSemanal
{
    public class Conexion: IConexion
    {
        private string connectionString =
            "Server=tcp:servidortrainee.database.windows.net,1433;Initial Catalog=bdTraine;Persist Security Info=False;User ID=ariana;Password=Contra123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;";

        public Conexion()
		{
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM RETOSEMANAL";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                        WriteLine($"La base de datos se reinició para volver a cargar los datos.");
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                WriteLine($"No se pudo eliminar los datos de la tabla para iniciar el programa. Error: {ex.Message}");
            }
            
        }

        public void Agregar(Vuelo info)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO RETOSEMANAL (id, origen, destino, fecha, aereopuerto, precio) " +
                        "VALUES (@id, @origen, @destino, @fecha, @aeropuerto,@precio)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", info.id);
                        command.Parameters.AddWithValue("@origen", info.origen);
                        command.Parameters.AddWithValue("@destino", info.destino);
                        command.Parameters.AddWithValue("@fecha", info.fecha);
                        command.Parameters.AddWithValue("@aeropuerto", info.aereopuerto);
                        command.Parameters.AddWithValue("@precio", info.precio);

                        command.ExecuteNonQuery();
                        
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"No se pudo agregar el vuelo a la base de datos. Vuelo ID: {info.id}. Error: {ex.Message}");
            }
        }

        public ListadoVuelos Consulta(string query)
        {
            ListadoVuelos lista = new ListadoVuelos();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    //string query = $"SELECT * FROM RETOSEMANAL where origen={origen}";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Vuelo infoVuelo = new Vuelo(
                                    Convert.ToInt32(reader["id"]),
                                    reader["origen"].ToString(),
                                    reader["destino"].ToString(),
                                    Convert.ToDateTime(reader["fecha"].ToString()),
                                    reader["aereopuerto"].ToString(),
                                    reader["precio"].ToString()
                                    );
                                lista.AgregarVuelo(infoVuelo);
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                WriteLine($"No se pudo hacer la busqueda:\n{query}\n");
            }
            return lista;
        }
	}
}

