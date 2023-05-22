using System;
namespace RetoSemanal4
{
	public interface IBiblioteca
	{
		public void AgregarMaterial(Material material);
		public List<Material> BuscarPorTitulo(string titulo);
        public bool PrestarMaterial(Material material);
        public bool DevolverMaterial(Material material);

    }
}

