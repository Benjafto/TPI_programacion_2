using CostaFascinosa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Interfaz
{
    public interface IPasajero_service
    {
        List<Pasajero> GetPasajeros();

        Pasajero GetPasajero(int id);

        bool add(Pasajero pasajero);

        bool delete(int id);

        bool update(Pasajero pasajero);
    }
}
