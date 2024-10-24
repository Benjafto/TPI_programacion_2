using CostaFascinosa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Interfaz
{
    public interface ITurno_repository
    {

        bool add(Turno turno);


        bool update(Turno turno);
    }
}
