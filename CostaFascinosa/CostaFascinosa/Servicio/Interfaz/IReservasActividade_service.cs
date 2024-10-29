using CostaFascinosa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Interfaz
{
    public interface IReservasActividade_service
    {
        List<ReservasActividade> GetReservasActividades();

        ReservasActividade GetReservaActividad(int id);

        bool add(ReservasActividade reservaActividad);

        bool delete(int id);

        bool update(ReservasActividade reservaActividad);
    }
}
