using CostaFascinosa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Interfaz
{
    public interface IReservasServicio_repository
    {


        bool add(ReservasServicio reservaServicio);

        bool delete(int id);

        bool update(ReservasServicio reservaServicio);

        List<ReservasServicio> GetReservasServicioByUsuario(int id);
        List<ReservasServicio> GetReservasServicioByActividad(int id);
        List<ReservasServicio> GetReservasServicioByFechaYUsuario(int id, DateTime fechaInicial, DateTime fechaFinal);
    }
}
