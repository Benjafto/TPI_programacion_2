using CostaFascinosa.Data;
using CostaFascinosa.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Implementacion
{
    public class Tematica_repository : ITematica_repository
    {
        private readonly COSTA_FASCINOSAContext _context;

        public Tematica_repository(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }

        public bool add(Tematica tematica)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public Tematica GetTematica(int id)
        {
            throw new NotImplementedException();
        }

        public List<Tematica> GetTematicas()
        {
            throw new NotImplementedException();
        }

        public bool update(Tematica tematica)
        {
            throw new NotImplementedException();
        }
    }
}
