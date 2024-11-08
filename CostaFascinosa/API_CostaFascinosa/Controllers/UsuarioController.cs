using CostaFascinosa.Servicio.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_CostaFascinosa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly IUsuario_service _serv;

        public UsuarioController(IUsuario_service serv)
        {
            _serv = serv;
        }

        [HttpGet]
        public IActionResult GetUsuarios(int id)
        {
            {
                try
                {
                    if (id == 0)
                    {
                        return BadRequest("Debe enviar datos válidos.");
                    }
                    else
                    {
                        return Ok( _serv.GetUsuario(id));
                    }
                }
                catch (Exception)
                {
                    return StatusCode(500, "Error interno.");
                }
            }
        }
    }
}
