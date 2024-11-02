using CostaFascinosa.Data;
using CostaFascinosa.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Implementacion
{
    public class Amenity_service : IAmenity_service
    {

        private readonly IAmenity_repository _repository;

        public Amenity_service(IAmenity_repository repository)
        {
            _repository = repository;
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
            return _repository.GetAmenities();
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
