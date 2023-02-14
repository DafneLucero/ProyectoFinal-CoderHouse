using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PrimerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("{usuario}/{contrasena}")]
        public Usuario Login(string usuario,string contrasena)
        {
            return UsuarioHandler.InicioSesion(usuario,contrasena);
            
        }

        [HttpPost]
        public void CrearUsuario (Usuario nuevoUsuario)
        {
            UsuarioHandler.CargarUsuario(nuevoUsuario);
        }

        [HttpPut]
        public void ModificarUsuario(Usuario nuevoUsuario)
        {
            UsuarioHandler.ModificarUsuario(nuevoUsuario);
        }

    }
}
