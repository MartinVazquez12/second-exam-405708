using Microsoft.EntityFrameworkCore;
using secondParcialWebAPI.Models;
using secondParcialWebAPI.Repositories.Interfaces;

namespace secondParcialWebAPI.Repositories
{
    public class SocioRepository : ISocioRepository
    {
        private readonly DbAa579fProg3w1Context _context;

        public SocioRepository(DbAa579fProg3w1Context context)
        {
            _context = context;
        }

        public async Task<Socio> Add(Socio socio)
        {
            _context.Add(socio);
            await _context.SaveChangesAsync();
            return socio;
        }

        public async Task<List<Socio>> GetAll()
        {
            return await _context.Socios.ToListAsync();
        }

        public async Task<Socio> GetById(Guid id)
        {
            var socio = await _context.Socios.FirstOrDefaultAsync(x => x.Id == id);
            if (socio == null)
            {
                throw new Exception();
            }
            return socio;
        }
    }
}
