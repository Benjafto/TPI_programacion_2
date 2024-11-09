using CostaFascinosa.Data;
using CostaFascinosa.Repositorio.Interfaz;
using CostaFascinosa.Servicio.Interfaz;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repositorio.Implementacion
{
    public class ConsumosHabitacione_repository : IConsumosHabitacione_repository
    {
        private readonly COSTA_FASCINOSAContext _context;

        public ConsumosHabitacione_repository(COSTA_FASCINOSAContext context)
        {
            _context = context;
        }

        public async Task<bool> Add(ConsumosHabitacione consumo)
        {
           
                try
                {
                    await _context.ConsumosHabitaciones.AddAsync(consumo);
                    var res = await _context.SaveChangesAsync() > 0;

                    return res;
                }
                catch (Exception)
                {

                    return false;
                }
        }

        public async Task<List<ConsumosHabitacione>> Get(int id)
        {
            return await _context.ConsumosHabitaciones.Where(x => x.IdUsuario == id)
                .Include(e => e.ReservasActividades)
                
                    .ThenInclude(ra => ra.IdActividadNavigation)

                .Include(e => e.ConsumosGastronomicos)
                    .ThenInclude(e => e.IdProductoNavigation)

                .ToListAsync();
        }
        public async Task<decimal?> ObtenerTotalConsumosYReservas(int idUsuario)
        {
            // Calcular el total de Consumos Gastronómicos
            var totalConsumosGastronomicos = await _context.ConsumosHabitaciones
                .Where(ch => ch.IdUsuario == idUsuario)
                .SelectMany(ch => ch.ConsumosGastronomicos)
                .SumAsync(cg => cg.Precio * cg.Cantidad);

            // Calcular el total de Reservas de Actividades
            var totalReservasActividades = await _context.ConsumosHabitaciones
                .Where(ch => ch.IdUsuario == idUsuario)
                .SelectMany(ch => ch.ReservasActividades)
                .SumAsync(ra => ra.CostoUnitario * ra.CantidadReservada);

            // Sumar ambos totales
            return totalConsumosGastronomicos + totalReservasActividades;

        }
    }
}
