using secondParcialWebAPI.Models;

namespace secondParcialWebAPI.Repositories.Interfaces
{
    public interface ISocioRepository
    {
        Task<List<Socio>> GetAll();
        Task<Socio> Add(Socio socio);
        Task<Socio> GetById(Guid id);
    }
}
