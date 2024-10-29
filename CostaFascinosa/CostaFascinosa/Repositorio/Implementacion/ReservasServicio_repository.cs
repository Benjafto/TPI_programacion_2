using CostaFascinosa.Data;
using CostaFascinosa.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Implementacion
{
    public class ReservasServicio_repository : IReservasServicio_repository
    {
        private readonly COSTA_FASCINOSAContext _context;

        public ReservasServicio_repository(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }

        public bool add(ReservasServicio reservaServicio)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ReservasServicio> GetReservasServicioByActividad(int id)
        {
            throw new NotImplementedException();
        }

        public List<ReservasServicio> GetReservasServicioByFechaYUsuario(int id, DateTime fechaInicial, DateTime fechaFinal)
        {
            throw new NotImplementedException();
        }

        public List<ReservasServicio> GetReservasServicioByUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public bool update(ReservasServicio reservaServicio)
        {
            throw new NotImplementedException();
        }
    }
}
