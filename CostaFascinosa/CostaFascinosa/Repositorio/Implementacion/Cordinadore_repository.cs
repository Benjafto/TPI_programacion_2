using CostaFascinosa.Data;
using CostaFascinosa.Repository.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Implementacion
{
    public class Cordinadore_repository : ICordinadore_repository
    {
        private readonly COSTA_FASCINOSAContext _context;

        public Cordinadore_repository(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }

        public bool add(Coordinadore cordinador)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public Coordinadore GetCoordinador(int id)
        {
            throw new NotImplementedException();
        }

        public List<Coordinadore> GetCoordinadores()
        {
            throw new NotImplementedException();
        }

        public bool update(Coordinadore cordinador)
        {
            throw new NotImplementedException();
        }
    }
}
