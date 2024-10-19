using CostaFascinosa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Interfaz
{
    public interface IZona_service
    {
        List<Zona> GetZonas();

        Zona GetZona(int id);

        bool add(Zona zona);

        bool delete(int id);

        bool update(Zona zona);
    }
}
