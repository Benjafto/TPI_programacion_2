using CostaFascinosa.Data;
using CostaFascinosa.Repositorio.Interfaz;
using CostaFascinosa.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repositorio.Implementacion
{
    public class Destinatario_repository : IDestinatario_repository
    {
        private readonly COSTA_FASCINOSAContext _context;

        public Destinatario_repository(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }

        public Task<bool> Add(Destinatario destinatario)
        {
            throw new NotImplementedException();
        }

        public Task<List<Destinatario>> GetDestinatarios()
        {
            throw new NotImplementedException();
        }
    }
}
