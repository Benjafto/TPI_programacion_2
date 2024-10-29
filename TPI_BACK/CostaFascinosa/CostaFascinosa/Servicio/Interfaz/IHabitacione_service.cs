using CostaFascinosa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Interfaz
{
    public interface IHabitacione_service
    {
        List<Habitacione> GetHabitaciones();

        Habitacione GetHabitacion(int id);

        bool add(Habitacione habitacion);

        bool delete(int id);

        bool update(Habitacione habitacion);
    }
}
