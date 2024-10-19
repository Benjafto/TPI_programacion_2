using CostaFascinosa.Data;
using CostaFascinosa.Repository.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Implementacion
{
    public class Actividade_repository : IActividade_repository
    {
        private readonly COSTA_FASCINOSAContext _context;

        public Actividade_repository(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }

        public bool add(Actividade actividad)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public Actividade GetActividad(int id)
        {
            throw new NotImplementedException();
        }

        public List<Actividade> GetActividades()
        {
            throw new NotImplementedException();
        }

        public bool update(Actividade actividad)
        {
            throw new NotImplementedException();
        }
    }
}
