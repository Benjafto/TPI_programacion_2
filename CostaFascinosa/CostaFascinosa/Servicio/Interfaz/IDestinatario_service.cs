using CostaFascinosa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Interfaz
{
    public interface IDestinatario_service
    {
        List<Destinatario> GetDestinatarios();

        Destinatario GetDestinatario(int id);

        bool add(Destinatario destinatario);

        bool delete(int id);

        bool update(Destinatario destinatario);

    }
}
