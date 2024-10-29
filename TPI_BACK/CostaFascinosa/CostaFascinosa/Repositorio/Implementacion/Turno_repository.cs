using CostaFascinosa.Data;
using CostaFascinosa.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Implementacion
{
    public class Turno_repository : ITurno_repository
    {
        private readonly COSTA_FASCINOSAContext _context;

        public Turno_repository(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }
        public Task<List<Turno>> GetAll()
        {
            throw new NotImplementedException();
        }
        public Task<bool> add(Turno turno)
        {
            throw new NotImplementedException();
        }
    }
}
