using CostaFascinosa.Data;
using CostaFascinosa.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Implementacion
{
    public class Zona_service : IZona_service
    {
        private readonly IZona_repository _repo;

        public Zona_service(IZona_repository repo)
        {
            _repo = repo;
        }

        public Task<bool> add(Zona zona)
        {
            throw new NotImplementedException();
        }

        public Task<List<Zona>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
