using CostaFascinosa.Data;
using CostaFascinosa.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Implementacion
{
    public class Pasajero_repository : IPasajero_repository
    {
        private readonly COSTA_FASCINOSAContext _context;

        public Pasajero_repository(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }

        public bool add(Pasajero pasajero)
        {
            throw new NotImplementedException();
        }
    }
}
