using CostaFascinosa.Data;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Interfaz
{
    public interface IActividade_repository
    {
        List<Actividade> GetActividades();

        Actividade GetActividad(int id);
        bool add(Actividade actividad);

        bool update(Actividade actividad);

        bool delete(int id);

        List<Actividade> GetActividadesByCategoria(int id);
        List<Actividade> GetActividadesByTurno(int id);
        List<Actividade> GetActividadesByDestinatario(int id);
        List<Actividade> GetActividadesByCodigoVestimenta(int id);
        List<Actividade> GetActividadesByZona(int id);
        List<Actividade> GetActividadesByRequiereReserva(bool requiereReserva);






    }
}
