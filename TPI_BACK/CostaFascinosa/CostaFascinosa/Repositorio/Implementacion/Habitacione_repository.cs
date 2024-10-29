using CostaFascinosa.Data;
using CostaFascinosa.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Implementacion
{
    public class Habitacione_repository : IHabitacione_repository
    {
        private readonly COSTA_FASCINOSAContext _context;

        public Habitacione_repository(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }

        public bool add(Habitacione habitacion)
        {
            throw new NotImplementedException();
        }

        public Habitacione GetHabitacion(int id)
        {
            throw new NotImplementedException();
        }
    }
}
