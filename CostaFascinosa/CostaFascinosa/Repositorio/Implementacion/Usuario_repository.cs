using CostaFascinosa.Data;
using CostaFascinosa.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Implementacion
{
    public class Usuario_repository : IUsuario_repository
    {
        private readonly COSTA_FASCINOSAContext _context;

        public Usuario_repository(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }

        public bool add(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario GetUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> GetUsuarios()
        {
            throw new NotImplementedException();
        }

        public bool update(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
