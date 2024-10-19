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

        CodVestimenta GetCodVestimenta(int id);

        bool add(CodVestimenta codVestimenta);

        bool delete(int id);

        bool update(CodVestimenta codVestimenta);
    }
}
