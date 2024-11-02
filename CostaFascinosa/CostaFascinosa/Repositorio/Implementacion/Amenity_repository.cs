using CostaFascinosa.Data;
using CostaFascinosa.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Implementacion
{
    public class Amenity_repository : IAmenity_repository
    {
        private readonly COSTA_FASCINOSAContext _context;

        public Amenity_repository(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }

        public List<Amenity> GetAmenities()
        {
            return _context.Amenities.ToList();
        }

        public List<Amenity> GetAmenitiesByCategoria(int id)
        {
            throw new NotImplementedException();
        }

        public List<Amenity> GetAmenitiesByCodigoVestimenta(int id)
        {
            throw new NotImplementedException();
        }

        public List<Amenity> GetAmenitiesByDestinatario(int id)
        {
            throw new NotImplementedException();
        }

        public List<Amenity> GetAmenitiesByTurno(int id)
        {
            throw new NotImplementedException();
        }

        public List<Amenity> GetAmenitiesByZona(int id)
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
        public bool add(Amenity amenity)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
