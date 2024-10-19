using CostaFascinosa.Data;
using CostaFascinosa.Repository.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Implementacion
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

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public Pasajero GetPasajero(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pasajero> GetPasajeros()
        {
            throw new NotImplementedException();
        }

        public bool update(Pasajero pasajero)
        {
            throw new NotImplementedException();
        }
    }
}
