using CostaFascinosa.Data;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Interfaz
{
    public interface IActividade_service
    {
        List<Actividade> GetActividades();

        Actividade GetActividad(int id);
        bool add(Actividade actividad);

        bool update(Actividade actividad);

        bool delete(int id);
        
    }
}
