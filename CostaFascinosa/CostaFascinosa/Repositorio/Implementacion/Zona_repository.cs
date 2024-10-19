using CostaFascinosa.Data;
using CostaFascinosa.Repository.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Implementacion
{
    public class Zona_repository : IZona_repository
    {
        private readonly COSTA_FASCINOSAContext _context;

        public Zona_repository(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }

        public bool add(Zona zona)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public Zona GetZona(int id)
        {
            throw new NotImplementedException();
        }

        public List<Zona> GetZonas()
        {
            throw new NotImplementedException();
        }

        public bool update(Zona zona)
        {
            throw new NotImplementedException();
        }
    }
}
