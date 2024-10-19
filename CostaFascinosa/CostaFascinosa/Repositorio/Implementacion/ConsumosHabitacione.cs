using CostaFascinosa.Data;
using CostaFascinosa.Repository.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Implementacion
{
    public class ConsumosHabitacione : IConsumosHabitacione_repository
    {
        private readonly COSTA_FASCINOSAContext _context;

        public ConsumosHabitacione(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }

        public bool add(Data.ConsumosHabitacione consumosHabitacione)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public Data.ConsumosHabitacione GetConsumoHabitacion(int id)
        {
            throw new NotImplementedException();
        }

        public List<Data.ConsumosHabitacione> GetConsumosHabitaciones()
        {
            throw new NotImplementedException();
        }

        public bool update(Data.ConsumosHabitacione consumosHabitacione)
        {
            throw new NotImplementedException();
        }
    }
}
