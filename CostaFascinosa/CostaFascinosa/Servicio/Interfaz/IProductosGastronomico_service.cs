using CostaFascinosa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Interfaz
{
    public interface IProductosGastronomico_service
    {
        List<ProductosGastronomico> GetProductosGastronomicos();

        ProductosGastronomico GetProductoGastronomico(int id);

        bool add(ProductosGastronomico productoGastronomico);

        bool delete(int id);

        bool update(ProductosGastronomico productoGastronomico);
    }
}
