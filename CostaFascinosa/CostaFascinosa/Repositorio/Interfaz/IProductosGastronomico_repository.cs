using CostaFascinosa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Interfaz
{
    public interface IProductosGastronomico_repository
    {

        ProductosGastronomico GetProductoGastronomico(int id);
        ProductosGastronomico GetProductosGastronomicoByTipo(int id);
        bool add(ProductosGastronomico productoGastronomico);

    }
}
