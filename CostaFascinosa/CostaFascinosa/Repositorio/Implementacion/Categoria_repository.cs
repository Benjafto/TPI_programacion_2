using CostaFascinosa.Data;
using CostaFascinosa.Repository.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Implementacion
{
    public class Categoria_repository : ICategoria_repository
    {
        private readonly COSTA_FASCINOSAContext _context;

        public Categoria_repository(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }

        public bool add(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public Categoria GetCategoria(int id)
        {
            throw new NotImplementedException();
        }

        public List<Categoria> GetCategorias()
        {
            throw new NotImplementedException();
        }

        public bool update(Categoria categoria)
        {
            throw new NotImplementedException();
        }
    }
}
