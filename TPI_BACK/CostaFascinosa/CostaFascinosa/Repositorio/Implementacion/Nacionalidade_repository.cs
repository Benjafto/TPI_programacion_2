using CostaFascinosa.Data;
using CostaFascinosa.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Implementacion
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
    }
}
