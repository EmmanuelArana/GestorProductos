using MiPrimeraAppMAUIBlazor.Class.Producto;

namespace MiPrimeraAppMauiBlazor.Services
{
    public class ProductoService
    {
        private List<ProductoListCLS> lista;

        public ProductoService()
        {
            lista = new List<ProductoListCLS>();
            lista.Add(new ProductoListCLS
            {
                IdProducto = 1,
                Nombre = "Laptop",
                Precio = 1200.50m,
                FechaCreacion = DateTime.Now
            });
            lista.Add(new ProductoListCLS
            {
                IdProducto = 2,
                Nombre = "Mouse",
                Precio = 25.99m,
                FechaCreacion = DateTime.Now
            });
        }

        public async Task<List<ProductoListCLS>> ListarProductos()
        {
            return lista;
        }

        public void AgregarProducto(ProductoListCLS producto)
        {
            lista.Add(producto);
        }
    }
}