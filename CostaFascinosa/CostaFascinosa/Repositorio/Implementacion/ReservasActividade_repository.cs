using CostaFascinosa.Data;
using CostaFascinosa.Servicio.Interfaz;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Implementacion
{
    public class ReservasActividade_repository : IReservasActividade_repository
    {
        private readonly COSTA_FASCINOSAContext _context;

        public ReservasActividade_repository(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }

        public async Task<List<ReservasActividade>> GetReservasActividadesByUsuario(int id)
        {
            return await _context.ReservasActividades
                .Where(x => x.IdConsumoNavigation.IdUsuario == id)
                .Include(e => e.IdActividadNavigation)
                .ToListAsync();
        }

        public async Task<List<ReservasActividade>> GetReservasActividadesDelDia(int id)
        {
            return await _context.ReservasActividades
                    .Where(x => x.IdConsumoNavigation.IdUsuario == id && x.FechaReservada == DateTime.Today)
                    .Include(e => e.IdActividadNavigation)
                    .ToListAsync();
        }
    }
}
