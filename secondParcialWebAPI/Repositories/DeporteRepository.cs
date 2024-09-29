using Microsoft.EntityFrameworkCore;
using secondParcialWebAPI.Models;
using secondParcialWebAPI.Repositories.Interfaces;

namespace secondParcialWebAPI.Repositories
{
    public class DeporteRepository : IDeporteRepository
    {
        private readonly DbAa579fProg3w1Context _context;

        public DeporteRepository(DbAa579fProg3w1Context context)
        {
            _context = context;
        }

        public async Task<List<Deporte>> GetAllDeportes()
        {
            return await _context.Deportes.ToListAsync();
        }
    }
}
