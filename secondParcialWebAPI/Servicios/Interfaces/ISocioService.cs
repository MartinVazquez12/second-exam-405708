using secondParcialWebAPI.DTOS;

namespace secondParcialWebAPI.Servicios.Interfaces
{
    public interface ISocioService
    {
        Task<ApiResponseDto<List<SocioDto>>> GetAllSocios();
        Task<ApiResponseDto<SocioAltaDto>> AddSocio(SocioAltaDto socioAltaDto);
        Task<ApiResponseDto<SocioDtoId>> GetById(Guid id);
    }
}
