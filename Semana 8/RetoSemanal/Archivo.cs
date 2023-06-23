using System;
namespace RetoSemanal
{
	public static class Archivo
	{

		public static ListadoVuelos CargarArchivo()
		{
            string archivoCSV = "Vuelosdisponibles.csv";
            ListadoVuelos listado = new ListadoVuelos();

            try
            {
                using (StreamReader archivo = new StreamReader(archivoCSV))
                {
                    var contador = 0;
                    while (!archivo.EndOfStream)
                    {
                        string linea = archivo.ReadLine();
                        var campos = linea.Split(',');

                        if(campos.Length == 6 && contador!=0)
                            {
                                Vuelo info = new Vuelo(
                                    Convert.ToInt32(campos[0]),
                                    campos[1].ToString(),
                                    campos[2].ToString(),
                                    Convert.ToDateTime(campos[3].ToString()),
                                    campos[5].ToString(),
                                    campos[4].ToString()
                                );
                                listado.AgregarVuelo(info);
                            }
                        contador++;
                            
                    }
                }
                
            }
            catch (IOException e)
            {
                Console.WriteLine("Error al leer el archivo: " + e.Message);
            }
            return listado;
        }
	}
}

