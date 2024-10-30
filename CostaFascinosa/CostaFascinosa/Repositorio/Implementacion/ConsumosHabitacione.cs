using CostaFascinosa.Data;
using CostaFascinosa.Repositorio.Interfaz;
using CostaFascinosa.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repositorio.Implementacion
{
    public class ConsumosHabitacione : IConsumosHabitacione_repository
    {
        private readonly COSTA_FASCINOSAContext _context;

        public ConsumosHabitacione(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }

        public List<Data.ConsumosHabitacione> GetConsumosHabitacionesByHabitacion(int numeroHabitacion)
        {
            throw new NotImplementedException();
        }
    }
}
