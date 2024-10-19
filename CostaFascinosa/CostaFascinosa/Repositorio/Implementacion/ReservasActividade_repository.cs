using CostaFascinosa.Data;
using CostaFascinosa.Repository.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Implementacion
{
    public class ReservasActividade_repository : IReservasActividade_repository
    {
        private readonly COSTA_FASCINOSAContext _context;

        public ReservasActividade_repository(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }

        public bool add(ReservasActividade reservaActividad)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public ReservasActividade GetReservaActividad(int id)
        {
            throw new NotImplementedException();
        }

        public List<ReservasActividade> GetReservasActividades()
        {
            throw new NotImplementedException();
        }

        public bool update(ReservasActividade reservaActividad)
        {
            throw new NotImplementedException();
        }
    }
}
