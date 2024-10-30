using CostaFascinosa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repositorio.Interfaz
{
    public interface IConsumosHabitacione_repository
    {
        List<ConsumosHabitacione> GetConsumosHabitacionesByHabitacion(int numeroHabitacion);

    }
}
