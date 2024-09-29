using AutoMapper;
using secondParcialWebAPI.DTOS;
using secondParcialWebAPI.Models;
using secondParcialWebAPI.Repositories.Interfaces;
using secondParcialWebAPI.Servicios.Interfaces;

namespace secondParcialWebAPI.Servicios
{
    public class DeporteService : IDeporteService
    {
        private readonly IDeporteRepository _repository;
        private readonly IMapper _mapper;

        public DeporteService(IDeporteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ApiResponseDto<List<DeporteDto>>> GetDeportes()
        {
            ApiResponseDto<List<DeporteDto>> response = new ApiResponseDto<List<DeporteDto>>();

            List<Deporte> lstdepo = await _repository.GetAllDeportes();

            if (lstdepo == null || lstdepo.Count == 0)
            {
                response.SetError("No existen", System.Net.HttpStatusCode.NotFound);
            }
            else
            {
                var depoDto = _mapper.Map<List<DeporteDto>>(lstdepo);
                for (int i = 0; i < lstdepo.Count; i++)
                {
                    depoDto[i].Id = lstdepo[i].Id;
                }
                response.Success = true;
                response.ErrorMessage = "Lista de deportes";
                response.Data = depoDto;
                response.StatusCode = System.Net.HttpStatusCode.OK;
            }
            return response;
        }
    }
}
