using CostaFascinosa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Interfaz
{
    public interface ITiposDocumento_repository
    {
        List<TiposDocumento> GetTiposDocumentos();

        TiposDocumento GetTiposDocumento(int id);

        bool add(TiposDocumento tiposDocumento);

        bool delete(int id);

        bool update(TiposDocumento tiposDocumento);
    }
}
