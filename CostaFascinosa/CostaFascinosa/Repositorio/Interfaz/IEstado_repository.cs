using CostaFascinosa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Interfaz
{
    public interface IEstado_repository
    {
        List<Estado> GetEstados();

        Estado GetEstado(int id);

        bool add(Estado estado);

        bool delete(int id);

        bool update(Estado estado);
    }
}
