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
        List<ReservasServicio> GetReservasServicios();

        ReservasServicio GetReservaServicio(int id);

        bool add(ReservasServicio reservaServicio);

        bool delete(int id);

        bool update(ReservasServicio reservaServicio);
    }
}
