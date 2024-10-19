using CostaFascinosa.Data;
using CostaFascinosa.Repository.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Implementacion
{
    public class Amenity_repository : IAmenity_service
    {
        private readonly COSTA_FASCINOSAContext _context;

        public Amenity_repository(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }

        public bool add(Amenity amenity)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Amenity> GetAmenities()
        {
            throw new NotImplementedException();
        }

        public Amenity GetAmenity(int id)
        {
            throw new NotImplementedException();
        }

        public bool update(Amenity amenity)
        {
            throw new NotImplementedException();
        }
    }
}
