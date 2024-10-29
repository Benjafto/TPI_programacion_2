using CostaFascinosa.Data;
using CostaFascinosa.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Implementacion
{
    public class PreferenciasAlimenticias_repository : IPreferenciaAlimenticia
    {
        private readonly COSTA_FASCINOSAContext _context;

        public PreferenciasAlimenticias_repository(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }

        public bool add(PreferenciasAlimenticia preferenciaAlimentici)
        {
            throw new NotImplementedException();
        }

        public PreferenciasAlimenticia GetPreferenciaAlimenticia(int id)
        {
            throw new NotImplementedException();
        }
    }
}
