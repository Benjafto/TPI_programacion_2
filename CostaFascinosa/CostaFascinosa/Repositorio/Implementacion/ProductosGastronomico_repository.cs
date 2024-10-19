using CostaFascinosa.Data;
using CostaFascinosa.Repository.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Implementacion
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

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public ProductosGastronomico GetProductoGastronomico(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductosGastronomico> GetProductosGastronomicos()
        {
            throw new NotImplementedException();
        }

        public bool update(ProductosGastronomico productoGastronomico)
        {
            throw new NotImplementedException();
        }
    }
}
