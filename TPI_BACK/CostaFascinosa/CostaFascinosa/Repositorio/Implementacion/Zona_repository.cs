using CostaFascinosa.Data;
using CostaFascinosa.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Implementacion
{
    public class Zona_repository : IZona_repository
    {
        private readonly COSTA_FASCINOSAContext _context;

        public Zona_repository(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }
        public Task<List<Zona>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<bool> add(Zona zona)
        {
            throw new NotImplementedException();
        }
    }
}
