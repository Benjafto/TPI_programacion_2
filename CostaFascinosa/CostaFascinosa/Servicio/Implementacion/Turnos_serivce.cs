using CostaFascinosa.Data;
using CostaFascinosa.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Implementacion
{
    public class Turnos_serivce : ITurno_service
    {
        private readonly IZona_repository _repository;

        public Turnos_serivce(IZona_repository repository)
        {
            _repository = repository;
        }

        public Task<bool> add(Turno turno)
        {
            throw new NotImplementedException();
        }

        public Task<List<Turno>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
