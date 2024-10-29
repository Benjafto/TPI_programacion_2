using CostaFascinosa.Data;
using CostaFascinosa.Servicio.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_CostaFascinosa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CodVestimentaController : ControllerBase
    {
        private readonly ICodVestimenta_service _serv;

        public CodVestimentaController(ICodVestimenta_service serv)
        {
            _serv = serv;
        }

        [HttpGet]
        public async Task<IActionResult> GetVestimenta()
        {
            return Ok(await _serv.GetCodigosVestimentas());
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CodVestimenta vestimenta)
        {
            try
            {
                if(vestimenta == null)
                {
                    return BadRequest("Debe ingresar datos válidos.");
                }
                else
                {
                    return Ok(await _serv.add(vestimenta));
                }
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno.");
            }
        }
        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery]int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest("Debe ingresar datos válidos.");
                }
                else
                {
                    var vestDeleted = await _serv.delete(id);
                    if(vestDeleted == false)
                    {
                        return NotFound("No se encontré ese código.");
                    }
                    else
                    {
                        return Ok("El código de vestimenta fue eliminado.");
                    }
                    
                }
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno.");
            }
        }
    }
}
