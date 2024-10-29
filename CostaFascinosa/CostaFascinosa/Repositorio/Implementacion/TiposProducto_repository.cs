using CostaFascinosa.Data;
using CostaFascinosa.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Implementacion
{
    public class TiposProducto_repository : ITiposProducto_repository
    {
        private readonly COSTA_FASCINOSAContext _context;

        public TiposProducto_repository(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }

        public bool add(TiposProducto tipoProducto)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public TiposProducto GetTipoProducto(int id)
        {
            throw new NotImplementedException();
        }

        public List<TiposProducto> GetTiposProductos()
        {
            throw new NotImplementedException();
        }

        public bool update(TiposProducto tipoProducto)
        {
            throw new NotImplementedException();
        }
    }
}
