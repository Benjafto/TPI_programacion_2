using CostaFascinosa.Data;
using CostaFascinosa.Repository.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Implementacion
{
    public class Destinatario_repository : IDestinatario_repository
    {
        private readonly COSTA_FASCINOSAContext _context;

        public Destinatario_repository(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }

        public bool add(Destinatario destinatario)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public Destinatario GetDestinatario(int id)
        {
            throw new NotImplementedException();
        }

        public List<Destinatario> GetDestinatarios()
        {
            throw new NotImplementedException();
        }

        public bool update(Destinatario destinatario)
        {
            throw new NotImplementedException();
        }
    }
}
