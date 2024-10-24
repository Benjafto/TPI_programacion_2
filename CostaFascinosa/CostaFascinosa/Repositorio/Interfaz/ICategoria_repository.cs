using CostaFascinosa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Interfaz
{
    public interface ICategoria_repository
    {
        List<Categoria> GetCategorias();
        bool add(Categoria categoria);
        bool delete(int id);
    }
}
