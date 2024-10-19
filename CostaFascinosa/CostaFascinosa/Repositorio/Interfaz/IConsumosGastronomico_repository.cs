using CostaFascinosa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Interfaz
{
    public interface IConsumosGastronomico_repository
    {
        List<ConsumosGastronomico> GetConsumosGastronomicos();

        ConsumosGastronomico GetConsumoGastronomico(int id);

        bool add(ConsumosGastronomico consumosGastronomico);

        bool delete(int id);

        bool update(ConsumosGastronomico consumosGastronomico);
    }
}
