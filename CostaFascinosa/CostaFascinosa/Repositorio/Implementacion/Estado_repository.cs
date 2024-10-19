using CostaFascinosa.Data;
using CostaFascinosa.Repository.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Implementacion
{
    public class Estado_repository : IEstado_repository
    {
        private readonly COSTA_FASCINOSAContext _context;
        public Estado_repository(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }

        public bool add(Estado estado)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public Estado GetEstado(int id)
        {
            throw new NotImplementedException();
        }

        public List<Estado> GetEstados()
        {
            throw new NotImplementedException();
        }

        public bool update(Estado estado)
        {
            throw new NotImplementedException();
        }
    }
}
