using CostaFascinosa.Data;
using CostaFascinosa.Repository.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Implementacion
{
    public class ResenasActividade_repository : IResenasActividade_repository
    {
        private readonly COSTA_FASCINOSAContext _context;

        public ResenasActividade_repository(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }

        public bool add(ResenasActividade resenaActividad)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public ResenasActividade GetResenaActividad(int id)
        {
            throw new NotImplementedException();
        }

        public List<ResenasActividade> GetResenasActividades()
        {
            throw new NotImplementedException();
        }

        public bool update(ResenasActividade resenaActividad)
        {
            throw new NotImplementedException();
        }
    }
}
