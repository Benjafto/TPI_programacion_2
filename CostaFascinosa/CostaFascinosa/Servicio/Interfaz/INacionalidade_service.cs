using CostaFascinosa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Interfaz
{
    public interface INacionalidade_service
    {
        List<Nacionalidade> GetNacionalidades();

        Nacionalidade GetNacionalidad(int id);

        bool add(Nacionalidade nacionalidad);

        bool delete(int id);

        bool update(Nacionalidade nacionalidad);
    }
}
