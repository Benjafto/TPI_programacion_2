using CostaFascinosa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Interfaz
{
    public interface ITiposProducto_repository
    {
        List<TiposProducto> GetTiposProductos();

        TiposProducto GetTipoProducto(int id);

        bool add(TiposProducto tipoProducto);

        bool delete(int id);

        bool update(TiposProducto tipoProducto);
    }
}
