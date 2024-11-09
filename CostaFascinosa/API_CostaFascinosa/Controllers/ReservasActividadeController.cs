using CostaFascinosa.Servicio.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_CostaFascinosa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservasActividadeController : ControllerBase
    {

        private readonly IReservasActividade_service _serv;

        public ReservasActividadeController(IReservasActividade_service serv)
        {
            _serv = serv;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _serv.GetReservasActividades(id));
        }

        [HttpGet("Diaria/{id}")]
        public async Task<IActionResult> GetDiaria(int id)
        {
            return Ok(await _serv.GetReservasActividadesDeHoy(id));
        }

    }
}
