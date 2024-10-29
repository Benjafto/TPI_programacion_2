using CostaFascinosa.Data;
using CostaFascinosa.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Implementacion
{
    public class TiposHabitacion_repository : ITiposHabitacion_repository
    {
        private readonly COSTA_FASCINOSAContext _context;

        public TiposHabitacion_repository(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }

        public bool add(TiposHabitacione tipoHabitacion)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public TiposHabitacione GetTipoHabitacion(int id)
        {
            throw new NotImplementedException();
        }

        public List<TiposHabitacione> GetTiposHabitaciones()
        {
            throw new NotImplementedException();
        }

        public bool update(TiposHabitacione tipoHabitacion)
        {
            throw new NotImplementedException();
        }
    }
}
