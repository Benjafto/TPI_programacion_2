using CostaFascinosa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Interfaz
{
    public interface ITipoContacto_service
    {
        List<TipoContacto> GetTipoContactos();

        TipoContacto GetTipoContacto(int id);

        bool add(TipoContacto tipoContacto);

        bool delete(int id);

        bool update(TipoContacto tipoContacto);
    }
}
