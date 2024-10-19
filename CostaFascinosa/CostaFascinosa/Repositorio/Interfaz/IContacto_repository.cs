using CostaFascinosa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Interfaz
{
    public interface IContacto_repository
    {
        List<Contacto> GetContactos();

        Contacto GetContacto(int id);

        bool add(Contacto contacto);

        bool delete(int id);

        bool update(Contacto contacto);
    }
}
