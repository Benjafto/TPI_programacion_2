using CostaFascinosa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Interfaz
{
    public interface ITurno_service
    {
        List<Turno> GetTurnos();

        Turno GetTurno(int id);

        bool add(Turno turno);

        bool delete(int id);

        bool update(Turno turno);
    }
}
