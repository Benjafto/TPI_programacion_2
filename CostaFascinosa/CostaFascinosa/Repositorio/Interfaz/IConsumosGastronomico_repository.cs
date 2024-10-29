using CostaFascinosa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Interfaz
{
    public interface IConsumosGastronomico_repository
    {
        bool add(ConsumosGastronomico consumosGastronomico);

        List<ConsumosGastronomico> GetConsumosGastronomicosByUsuario(int id);

        List<ConsumosGastronomico> GetConsumosGastronomicosByFechaYUsuario(int id, DateTime fechaInicial, DateTime fechaFinal);


    }
}
