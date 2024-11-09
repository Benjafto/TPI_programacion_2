using CostaFascinosa.Servicio.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_CostaFascinosa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsumosGastronomicosController : ControllerBase
    {
        private readonly IConsumosGastronomico_service _serv;

        public ConsumosGastronomicosController(IConsumosGastronomico_service serv)
        {
            _serv = serv;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _serv.GetConsumosGastroByUsuario(id));
        }

        [HttpGet("TotalConsumo/{id}")]
        public async Task<IActionResult> GetTotales(int id)
        {
            return Ok(await _serv.GetConsumosGastronomicosTotales(id));
        }
    }
}
