using CostaFascinosa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Interfaz
{
    public interface IReservasActividade_repository
    {
        bool add(ReservasActividade reservaActividad);

        bool delete(int id);

        bool update(ReservasActividade reservaActividad);

        List <ReservasActividade> GetReservasActividadesByUsuario(int id);
        List<ReservasActividade> GetReservasActividadesByActividad(int id);
        List<ReservasActividade> GetReservasActividadesByFechaYUsuario(int id, DateTime fechaInicial, DateTime fechaFinal);



    }
}
