using CostaFascinosa.Data;
using CostaFascinosa.Repository.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Implementacion
{
    public class TiposServicio_service : ITiposServicio_service
    {
        private readonly ITiposServicio_repository _repository;

        public TiposServicio_service(ITiposServicio_repository repository)
        {
            _repository = repository;
        }

        public bool add(TiposServicio tipoServicio)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public TiposServicio GetTipoServicio(int id)
        {
            throw new NotImplementedException();
        }

        public List<TiposServicio> GetTiposServicios()
        {
            throw new NotImplementedException();
        }

        public bool update(TiposServicio tipoServicio)
        {
            throw new NotImplementedException();
        }
    }
}
