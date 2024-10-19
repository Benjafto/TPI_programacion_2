using CostaFascinosa.Data;
using CostaFascinosa.Repository.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Implementacion
{
    public class Contacto_repository : IContacto_repository
    {

        private readonly COSTA_FASCINOSAContext _context;

        public Contacto_repository(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }

        public bool add(Contacto contacto)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public Contacto GetContacto(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contacto> GetContactos()
        {
            throw new NotImplementedException();
        }

        public bool update(Contacto contacto)
        {
            throw new NotImplementedException();
        }
    }
}
