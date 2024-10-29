using CostaFascinosa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Interfaz
{
    public interface IUsuario_service
    {
        List<Usuario> GetUsuarios();

        Usuario GetUsuario(int id);

        bool add(Usuario usuario);

        bool delete(int id);

        bool update(Usuario usuario);
    }
}
