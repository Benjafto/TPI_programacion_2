using CostaFascinosa.Data;
using CostaFascinosa.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Implementacion
{
    public class TiposServicio_repository : ITiposServicio_repository
    {
        private readonly COSTA_FASCINOSAContext _context;

        public TiposServicio_repository(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }

        public bool add(TiposServicio tipoServicio)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public TiposServicio GetTipoServicio(int id)
        {
            throw new NotImplementedException();
        }

        public List<TiposServicio> GetTiposServicios()
        {
            throw new NotImplementedException();
        }

        public bool update(TiposServicio tipoServicio)
        {
            throw new NotImplementedException();
        }
    }
}
