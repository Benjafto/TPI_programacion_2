using CostaFascinosa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Interfaz
{
    public interface IContacto_service
    {
        List<Contacto> GetContactos();

        Contacto GetContacto(int id);

        bool add(Contacto contacto);

        bool delete(int id);

        bool update(Contacto contacto);
    }
}
