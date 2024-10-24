using CostaFascinosa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Interfaz
{
    public interface ICodVestimenta_repository
    {
        List<CodVestimenta> GetCodigosVestimentas();

        bool add(CodVestimenta codVestimenta);

        bool delete(int id);

    }
}
