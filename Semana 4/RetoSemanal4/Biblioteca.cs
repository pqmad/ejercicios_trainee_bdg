using System;
using System.Linq;
using static System.Console;

namespace RetoSemanal4
{
	public class Biblioteca:IBiblioteca
	{
        public List<Material> ListadoBiblioteca { get; private set; }

		public Biblioteca()
		{
            ListadoBiblioteca = new List<Material> ();

        }

        public void AgregarMaterial(Material material)
        {
            ListadoBiblioteca.Add(material);
        }

        public List<Material> BuscarPorTitulo(string titulo)
        {
            List<Material> listadoResultados = new List<Material>();
            foreach (var item in ListadoBiblioteca)
            {
                if (item.Titulo.ToLower().Contains(titulo.ToLower().Trim()))
                {
                    listadoResultados.Add(item);
                }
            }
            return listadoResultados;
        }

        public void DevolverMaterial(Material material)
        {
            foreach (var item in ListadoBiblioteca)
            {
                if (item.Titulo.ToLower().Contains(material.Titulo.ToLower().Trim()))
                {
                    if (item.GetType() == typeof(Libro) && material.GetType() == typeof(Libro))
                    {
                        Libro libro = (Libro)item;
                        libro.Devolver();
                        return;
                    }
                    else if (item.GetType() == typeof(Revista) && material.GetType() == typeof(Revista))
                    {
                        if (!item.Disponible)
                        {
                            item.Disponible = true;
                            WriteLine($"Se DEVOLVIO el {item.Titulo} con exito");
                            return;
                        }
                        WriteLine($"NO se devolvio el {item.Titulo}");
                        return;
                    }
                }
            }
        }

        public void PrestarMaterial(Material material)
        {
            foreach (var item in ListadoBiblioteca)
            {
                if (item.Titulo.ToLower().Contains(material.Titulo.ToLower().Trim()))
                {
                    if (item.GetType() == typeof(Libro) && material.GetType() == typeof(Libro))
                    {
                        Libro libro = (Libro)item;
                        libro.Prestar();
                        return;
                    }else if(item.GetType()== typeof(Revista) && material.GetType() == typeof(Revista))
                    {
                        Revista revista = (Revista)item;
                        revista.Prestar();
                        return;
                    }
                }
            }
            
        }
    }
}

