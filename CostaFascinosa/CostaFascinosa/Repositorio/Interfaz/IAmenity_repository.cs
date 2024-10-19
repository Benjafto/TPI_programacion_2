using CostaFascinosa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Interfaz
{
    public interface IAmenity_repository
    {
        List<Amenity> GetAmenities();

        Amenity GetAmenity(int id);
        bool add(Amenity amenity);

        bool update(Amenity amenity);

        bool delete(int id);
    }
}
