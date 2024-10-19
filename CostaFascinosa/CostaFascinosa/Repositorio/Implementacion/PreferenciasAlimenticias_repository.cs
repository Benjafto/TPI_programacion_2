using CostaFascinosa.Data;
using CostaFascinosa.Repository.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Implementacion
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

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public PreferenciasAlimenticia GetPreferenciaAlimenticia(int id)
        {
            throw new NotImplementedException();
        }

        public List<PreferenciasAlimenticia> GetPreferenciasAlimenticias()
        {
            throw new NotImplementedException();
        }

        public bool update(PreferenciasAlimenticia preferenciaAlimenticia)
        {
            throw new NotImplementedException();
        }
    }
}
