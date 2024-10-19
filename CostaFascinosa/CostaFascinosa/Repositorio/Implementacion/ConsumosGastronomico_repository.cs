using CostaFascinosa.Data;
using CostaFascinosa.Repository.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Implementacion
{
    public class ConsumosGastronomico_repository : IConsumosGastronomico_repository
    {
        private readonly COSTA_FASCINOSAContext _context;

        public ConsumosGastronomico_repository(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }

        public bool add(ConsumosGastronomico consumosGastronomico)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public ConsumosGastronomico GetConsumoGastronomico(int id)
        {
            throw new NotImplementedException();
        }

        public List<ConsumosGastronomico> GetConsumosGastronomicos()
        {
            throw new NotImplementedException();
        }

        public bool update(ConsumosGastronomico consumosGastronomico)
        {
            throw new NotImplementedException();
        }
    }
}
