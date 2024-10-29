using CostaFascinosa.Servicio.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_CostaFascinosa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurnoController : ControllerBase
    {
        private readonly ITurno_service _serv;

        public TurnoController(ITurno_service serv)
        {
            _serv = serv;
        }
    }
}
