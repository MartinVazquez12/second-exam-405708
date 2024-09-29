using secondParcialWebAPI.DTOS;

namespace secondParcialWebAPI.Servicios.Interfaces
{
    public interface IDeporteService
    {
        Task<ApiResponseDto<List<DeporteDto>>> GetDeportes();
    }
}
