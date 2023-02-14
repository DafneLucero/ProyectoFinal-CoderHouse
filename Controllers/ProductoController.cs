using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PrimerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {

        [HttpPost]
        public void CrearProducto(Producto nuevoProducto)
        {
            ProductoHandler.CargarProducto(nuevoProducto);
        }

        [HttpGet("{id}")]
        public Producto BuscarProductoID(long id)
        {
            return ProductoHandler.obtenerProductoPorId(id);
        }

        [HttpPut("{idProducto}")]
        public int ModificarProducto(long idProducto, Producto aModificar)
        {
            return ProductoHandler.ModificarProducto(idProducto, aModificar);
        }

        [HttpDelete("{id}")]
        public int BorrarProducto (long id)
        {
            return ProductoHandler.EliminarProducto(id);
        }


    }
}
