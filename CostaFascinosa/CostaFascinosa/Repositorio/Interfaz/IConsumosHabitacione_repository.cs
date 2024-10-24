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
        List<ConsumosHabitacione> GetConsumosHabitacionesByHabitacion(int numeroHabitacion);


    }
}
