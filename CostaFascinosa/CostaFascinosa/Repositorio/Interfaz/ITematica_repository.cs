using CostaFascinosa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Interfaz
{
    public interface ITematica_repository
    {
        List<Tematica> GetTematicas();

        Tematica GetTematica(int id);

        bool add(Tematica tematica);

        bool delete(int id);

        bool update(Tematica tematica);
    }
}
