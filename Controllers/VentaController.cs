using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PrimerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {

        [HttpPost("{idUsuario}")]
        public void CargarNuevaVenta(long idUsuario, List<Producto> productosVendidos)
        {
            VentasHandler.CargarVenta(idUsuario, productosVendidos);
        }
    }
}
