using CostaFascinosa.Data;
using CostaFascinosa.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Implementacion
{
    public class ProductosGastronomico_repository : IProductosGastronomico_repository
    {
        private readonly COSTA_FASCINOSAContext _context;

        public ProductosGastronomico_repository(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }

        public bool add(ProductosGastronomico productoGastronomico)
        {
            throw new NotImplementedException();
        }

        public ProductosGastronomico GetProductoGastronomico(int id)
        {
            throw new NotImplementedException();
        }

        public ProductosGastronomico GetProductosGastronomicoByTipo(int id)
        {
            throw new NotImplementedException();
        }
    }
}
