using System;
using System.Text;
using Newtonsoft.Json;
using static System.Console;

namespace RetoSemanal
{
	public class Chiste
	{
        private const string _rutaArchivo = "jokes.txt";
        public string id { get; set; }
        public string value { get; set; }

        public async Task ObtenerChiste()
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = "https://api.chucknorris.io/jokes/random";
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string jokeJson = await response.Content.ReadAsStringAsync();
                    id = JsonConvert.DeserializeObject<Chiste>(jokeJson).id;
                    value = JsonConvert.DeserializeObject<Chiste>(jokeJson).value;

                    if (!Busqueda(id, false))
                    {
                        GuardarDatos();
                    }
                    else
                    {
                        WriteLine("El chiste ya existe en el archivo.");
                    }
                }
                else
                {
                    WriteLine("No se pudo obtener un chiste. Error en la API.");
                }
            }
        }

        public void GuardarDatos()
        {
            var cadena = $"{id}##{value}//";
            try
            {
                FileStream archivojugadores;
                if (File.Exists(_rutaArchivo))
                {
                    archivojugadores = new FileStream(_rutaArchivo, FileMode.Append);
                }
                else
                {
                    archivojugadores = new FileStream(_rutaArchivo, FileMode.Create);
                }
                archivojugadores.Write(ASCIIEncoding.ASCII.GetBytes(cadena), 0, cadena.Length);
                archivojugadores.Close();

                Console.WriteLine("El chiste se ha GUARDADO correctamente.");
            }
            catch (Exception ex)
            {
                WriteLine("No se pudo guardar el chiste en el archivo");
            }
        }

        public bool Busqueda(String aBuscar, bool busquedaCliente)
        {
            var encontroChisteCliente = false;
            if (File.Exists(_rutaArchivo))
            {
                FileStream archivo;
                byte[] contenido = new byte[100000];

                archivo = new FileStream(_rutaArchivo, FileMode.Open);
                archivo.Read(contenido, 0, (int)archivo.Length);
                archivo.Close();

                var texto = ASCIIEncoding.ASCII.GetString(contenido).Split("//");
                
                foreach (var chiste in texto)
                {
                    var datosChiste = chiste.Split("##");
                    if(datosChiste.Length > 1)
                    {
                        if (!busquedaCliente && datosChiste[0].Equals(aBuscar))
                        {
                            return true;
                        }
                        else if (busquedaCliente && datosChiste[1].ToLower().Contains(aBuscar.ToLower()))
                        {
                            WriteLine("-----------------------------");
                            WriteLine($"ID:  {datosChiste[0]}");
                            WriteLine($"CHISTE:  {datosChiste[1]}");
                            WriteLine("-----------------------------");
                            encontroChisteCliente = true;
                        }
                    }
                    
                }
               
            }
            return encontroChisteCliente;
        }


    }
}

