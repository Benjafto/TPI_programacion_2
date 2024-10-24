using CostaFascinosa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Interfaz
{
    public interface ICordinadore_repository
    {
        List<Coordinadore> GetCoordinadores();

        bool add(Coordinadore cordinador);

        bool delete(int id);

        bool update(Coordinadore cordinador);
    }
}
