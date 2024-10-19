using CostaFascinosa.Data;
using CostaFascinosa.Repository.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Implementacion
{
    public class Nacionalidade_repository : INacionalidade_repository
    {
        private readonly COSTA_FASCINOSAContext _context;

        public Nacionalidade_repository(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }

        public bool add(Nacionalidade nacionalidad)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public Nacionalidade GetNacionalidad(int id)
        {
            throw new NotImplementedException();
        }

        public List<Nacionalidade> GetNacionalidades()
        {
            throw new NotImplementedException();
        }

        public bool update(Nacionalidade nacionalidad)
        {
            throw new NotImplementedException();
        }
    }
}
