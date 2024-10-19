using CostaFascinosa.Data;
using CostaFascinosa.Repository.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Implementacion
{
    public class Turno_repository : ITurno_repository
    {
        private readonly COSTA_FASCINOSAContext _context;

        public Turno_repository(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }

        public bool add(Turno turno)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public Turno GetTurno(int id)
        {
            throw new NotImplementedException();
        }

        public List<Turno> GetTurnos()
        {
            throw new NotImplementedException();
        }

        public bool update(Turno turno)
        {
            throw new NotImplementedException();
        }
    }
}
