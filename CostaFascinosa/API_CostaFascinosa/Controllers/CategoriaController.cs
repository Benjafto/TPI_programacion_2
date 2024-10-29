using CostaFascinosa.Servicio.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CostaFascinosa.Data;


namespace API_CostaFascinosa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoria_service _serv;

        public CategoriaController(ICategoria_service serv)
        {
            _serv = serv;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _serv.GetCategorias());
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Categoria cat)
        {
            try
            {
                if(cat == null)
                {
                    return BadRequest("Debe enviar datos válidos.");
                }
                else
                {
                    return Ok(await _serv.add(cat));
                }
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno.");
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            try
            {
                var catdeleted = await _serv.delete(id);
                if (catdeleted != false)
                {
                    return Ok("La cateogoría fue borrada.");
                }
                else
                {
                    return NotFound("No existe el item a borrar.");
                }
            }
            catch (Exception)
            {

                return StatusCode(500, "Error interno.");
            }
        }

    }
}
