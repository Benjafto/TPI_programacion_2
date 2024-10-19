using CostaFascinosa.Data;
using CostaFascinosa.Repository.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Implementacion
{
    public class ServiciosGastronomico_repository : IServicioGastronomico_repository
    {
        private readonly COSTA_FASCINOSAContext _context;

        public ServiciosGastronomico_repository(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }

        public bool add(ServiciosGastronomico servicioGastronomico)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public ServiciosGastronomico GetServicioGastronomico(int id)
        {
            throw new NotImplementedException();
        }

        public List<ServiciosGastronomico> GetServiciosGastronomicos()
        {
            throw new NotImplementedException();
        }

        public bool update(ServiciosGastronomico servicioGastronomico)
        {
            throw new NotImplementedException();
        }
    }
}
