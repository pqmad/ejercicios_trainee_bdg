using System;
using System.Linq;

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

        public bool DevolverMaterial(Material material)
        {
            foreach (var item in ListadoBiblioteca)
            {
                if (item.Titulo.ToLower().Contains(material.Titulo.ToLower().Trim())
                    && !item.Disponible)
                {
                    item.Disponible = true;
                    return true;
                }
            }
            return false;
        }

        public bool PrestarMaterial(Material material)
        {
            foreach (var item in ListadoBiblioteca)
            {
                if (item.Titulo.ToLower().Contains(material.Titulo.ToLower().Trim())
                    && item.Disponible)
                {
                    item.Disponible = false;
                    return true;
                }
            }
            return false;
        }
    }
}

