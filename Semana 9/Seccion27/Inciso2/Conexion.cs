using System;
using Microsoft.Data.SqlClient;
using static System.Console;

namespace Inciso2
{
    public class Conexion : IConexion
    {
        private static string connectionString =
            "Server=tcp:servidortrainee.database.windows.net,1433;Initial Catalog=bdTraine;Persist Security Info=False;User ID=ariana;Password=Contra123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;";

        

        public void AgregarCita(Cita info)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO CITA (fecha, descripcion, contacto) " +
                        "VALUES (@fecha, @descripcion, @contacto)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@fecha", info.Fecha);
                        command.Parameters.AddWithValue("@descripcion", info.Descripcion);
                        command.Parameters.AddWithValue("@contacto", $"{info.Persona.Nombre} {info.Persona.Apellidos}");

                        command.ExecuteNonQuery();

                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"No se pudo agregar a la base de datos.");
            }
        }

        public void AgregarContacto(Contacto info)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO CONTACTO (nombre, apellido, telefono, localidad) " +
                        "VALUES (@nombre,@apellido, @telefono, @localidad)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", info.Nombre);
                        command.Parameters.AddWithValue("@apellido", info.Apellidos);
                        command.Parameters.AddWithValue("@telefono", info.Telefono);
                        command.Parameters.AddWithValue("@localidad", info.Localidad);

                        command.ExecuteNonQuery();

                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"No se pudo agregar a la base de datos.");
            }
        }

        
        public List<Cita> ConsultaCita(string query)
        {
            List<Cita> lista = new List<Cita> { };
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
                                List<Contacto> encontrados =
                                    ConsultaContacto($"Select * from CONTACTO where UPPER(nombre + ' ' + apellido) ='{reader["contacto"].ToString().ToUpper()}'");
                                Cita infoCita = new Cita(
                                    Convert.ToDateTime(reader["fecha"].ToString()),
                                    reader["descripcion"].ToString(),
                                    encontrados[0]
                                    );
                                lista.Add(infoCita);
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

        public List<Contacto> ConsultaContacto(string query)
        {
            List<Contacto> lista = new List<Contacto> { };
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
                                Contacto infoContacto = new Contacto(
                                    reader["nombre"].ToString(),
                                    reader["apellido"].ToString(),
                                    reader["telefono"].ToString(),
                                    reader["localidad"].ToString()
                                    );
                                lista.Add(infoContacto);
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

