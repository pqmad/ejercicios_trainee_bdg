using System;
namespace RetoSemanal4
{
	public interface IBiblioteca
	{
		public void AgregarMaterial(Material material);
		public List<Material> BuscarPorTitulo(string titulo);
        public void PrestarMaterial(Material material);
        public void DevolverMaterial(Material material);

    }
}

