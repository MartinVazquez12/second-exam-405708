using secondParcialWebAPI.Models;

namespace secondParcialWebAPI.Repositories.Interfaces
{
    public interface IDeporteRepository
    {
        Task<List<Deporte>> GetAllDeportes();
    }
}
