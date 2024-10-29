using CostaFascinosa.Data;
using CostaFascinosa.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Implementacion
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

        public List<ConsumosGastronomico> GetConsumosGastronomicosByFechaYUsuario(int id, DateTime fechaInicial, DateTime fechaFinal)
        {
            throw new NotImplementedException();
        }

        public List<ConsumosGastronomico> GetConsumosGastronomicosByUsuario(int id)
        {
            throw new NotImplementedException();
        }
    }
}
