using CostaFascinosa.Data;
using CostaFascinosa.Repository.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Implementacion
{
    public class TiposContacto_repository : ITipoContacto_repository
    {
        private readonly COSTA_FASCINOSAContext _context;

        public TiposContacto_repository(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }

        public bool add(TipoContacto tipoContacto)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public TipoContacto GetTipoContacto(int id)
        {
            throw new NotImplementedException();
        }

        public List<TipoContacto> GetTipoContactos()
        {
            throw new NotImplementedException();
        }

        public bool update(TipoContacto tipoContacto)
        {
            throw new NotImplementedException();
        }
    }
}
