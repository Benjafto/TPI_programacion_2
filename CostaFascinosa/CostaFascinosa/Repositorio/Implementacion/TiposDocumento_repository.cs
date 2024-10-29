using CostaFascinosa.Data;
using CostaFascinosa.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Implementacion
{
    public class TiposDocumento_repository : ITiposDocumento_repository
    {
        private readonly COSTA_FASCINOSAContext _context;

        public TiposDocumento_repository(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }

        public bool add(TiposDocumento tiposDocumento)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public TiposDocumento GetTiposDocumento(int id)
        {
            throw new NotImplementedException();
        }

        public List<TiposDocumento> GetTiposDocumentos()
        {
            throw new NotImplementedException();
        }

        public bool update(TiposDocumento tiposDocumento)
        {
            throw new NotImplementedException();
        }
    }
}
