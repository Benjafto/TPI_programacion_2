using CostaFascinosa.Data;
using CostaFascinosa.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Implementacion
{
    public class ConsumosHabitacione : IConsumosHabitacione_repository
    {
        private readonly COSTA_FASCINOSAContext _context;

        public ConsumosHabitacione(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }

        public List<ConsumosHabitacione> GetConsumosHabitacionesByHabitacion(int numeroHabitacion)
        {
            throw new NotImplementedException();
        }

        List<Data.ConsumosHabitacione> IConsumosHabitacione_repository.GetConsumosHabitacionesByHabitacion(int numeroHabitacion)
        {
            throw new NotImplementedException();   //QUÉ ES ESTO???
        }
    }
}
