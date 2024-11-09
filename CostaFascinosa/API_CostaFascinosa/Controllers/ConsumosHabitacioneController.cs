using CostaFascinosa.Data;
using CostaFascinosa.Servicio.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace API_CostaFascinosa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsumosHabitacioneController : ControllerBase
    {

        private readonly IConsumosHabitacione_service _serv;

        public ConsumosHabitacioneController(IConsumosHabitacione_service serv)
        {
            _serv = serv;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] int id)
        {
            return Ok(await _serv.GetConsumosHabitaciones(id)); 
        }
        [HttpGet("Total/{id}")]
        public async Task<IActionResult> GetTotal(int id)
        {
            return Ok(new {total = await _serv.ObtenerTotalConsumosYReservas(id) });  //crea un objeto
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ConsumosHabitacione consumo)
        {
            try
            {
                if (consumo == null)
                {
                    return BadRequest("Envíe todos los datos");
                }
                else
                {
                    return Ok(await _serv.Add(consumo));
                }

            }
            catch (Exception)
            {

                return StatusCode(500, "Error interno");
            }
        }
    }
}
