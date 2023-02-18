using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PrimerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        [HttpGet("{idUsuario}")]
        public List<ProductoVendido> BuscarProductosVendidosPorUsuario(long idUsuario)
        {
            return ProductoVendidoHandler.obtenerProductosVendidosPorUsuario(idUsuario);
        }
    }
}
