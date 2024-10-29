using CostaFascinosa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Interfaz
{
    public interface IDestinatario_repository
    {
        List<Destinatario> GetDestinatarios();

        bool add(Destinatario destinatario);

    }
}
