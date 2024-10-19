using CostaFascinosa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Interfaz
{
    public interface ICategoria_service
    {
        List<Categoria> GetCategorias();

        Categoria GetCategoria(int id);
        bool add(Categoria categoria);

        bool update(Categoria categoria);

        bool delete(int id);
    }
}
