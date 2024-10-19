using CostaFascinosa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Interfaz
{
    public interface IConsumosHabitacione_repository
    {
        List<ConsumosHabitacione> GetConsumosHabitaciones();

        ConsumosHabitacione GetConsumoHabitacion(int id);

        bool add(ConsumosHabitacione consumosHabitacione);

        bool delete(int id);

        bool update(ConsumosHabitacione consumosHabitacione);
    }
}
