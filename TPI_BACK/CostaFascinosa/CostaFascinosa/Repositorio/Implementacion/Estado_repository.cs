using CostaFascinosa.Data;
using CostaFascinosa.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Implementacion
{
    public class Estado_repository : IEstado_repository
    {
        private readonly COSTA_FASCINOSAContext _context;
        public Estado_repository(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }

        public bool add(Estado estado)
        {
            throw new NotImplementedException();
        }
    }
}
