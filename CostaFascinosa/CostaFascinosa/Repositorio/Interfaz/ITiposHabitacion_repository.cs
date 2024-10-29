using CostaFascinosa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Interfaz
{
    public interface ITiposHabitacion_repository
    {
        List<TiposHabitacione> GetTiposHabitaciones();

        TiposHabitacione GetTipoHabitacion(int id);

        bool add(TiposHabitacione tipoHabitacion);

        bool delete(int id);

        bool update(TiposHabitacione tipoHabitacion);
    }
}
