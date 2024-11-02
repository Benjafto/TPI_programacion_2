using CostaFascinosa.Data;
using CostaFascinosa.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Implementacion
{
    public class Actividade_service : IActividade_service
    {

        private readonly IActividade_repository _repository;

        public Actividade_service(IActividade_repository repository)
        {
            _repository = repository;
        }

        public bool add(Actividade actividad)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public Actividade GetActividad(int id)
        {
            throw new NotImplementedException();
        }

        public List<Actividade> GetActividades()
        {
            return _repository.GetActividades();
        }

        public bool update(Actividade actividad)
        {
            throw new NotImplementedException();
        }
    }
}
