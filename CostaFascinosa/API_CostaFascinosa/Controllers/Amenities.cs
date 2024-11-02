using CostaFascinosa.Servicio.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_CostaFascinosa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Amenities : ControllerBase
    {

        private readonly IAmenity_service _service;

        public Amenities(IAmenity_service service
            )
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetAmenities());
        }
    }
}
