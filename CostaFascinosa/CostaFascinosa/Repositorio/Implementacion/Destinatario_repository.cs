using CostaFascinosa.Data;
using CostaFascinosa.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Implementacion
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

        public List<Destinatario> GetDestinatarios()
        {
            throw new NotImplementedException();
        }
    }
}
