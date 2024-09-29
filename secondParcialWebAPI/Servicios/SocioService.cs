using AutoMapper;
using secondParcialWebAPI.DTOS;
using secondParcialWebAPI.Models;
using secondParcialWebAPI.Repositories.Interfaces;
using secondParcialWebAPI.Servicios.Interfaces;

namespace secondParcialWebAPI.Servicios
{
    public class SocioService : ISocioService
    {
        private readonly ISocioRepository _repository;
        private readonly IMapper _mapper;

        public SocioService(ISocioRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ApiResponseDto<SocioAltaDto>> AddSocio(SocioAltaDto socioAltaDto)
        {
            var response = new ApiResponseDto<SocioAltaDto>();

            socioAltaDto.Id = Guid.NewGuid();
            var socioToMap = _mapper.Map<Socio>(socioAltaDto);

            var socioAdd = await _repository.Add(socioToMap);
            if (socioAdd != null)
            {
                var socioDtoAdd = _mapper.Map<SocioAltaDto>(socioAdd);
                response.Success = true;
                response.Data = socioDtoAdd;
                response.StatusCode = System.Net.HttpStatusCode.OK;
            }
            else
            {
                response.SetError("No se pudo agregar", System.Net.HttpStatusCode.InternalServerError);
            }
            return response;
        }

        public async Task<ApiResponseDto<List<SocioDto>>> GetAllSocios()
        {
            var response = new ApiResponseDto<List<SocioDto>>();
            var socios = await _repository.GetAll();
            if (socios != null || socios.Count > 0)
            {
                var sociosDto = _mapper.Map<List<SocioDto>>(socios);
                response.Data = sociosDto;
                response.Success = true;
                response.StatusCode = System.Net.HttpStatusCode.OK;
            }
            else
            {
                response.SetError("No se encontraron pilotos", System.Net.HttpStatusCode.InternalServerError);
            }
            return response;
        }
        public async Task<ApiResponseDto<SocioDtoId>> GetById(Guid id)
        {
            var response = new ApiResponseDto<SocioDtoId>();
            var socio = await _repository.GetById(id);
            if (socio != null)
            {
                var socioDto = _mapper.Map<SocioDtoId>(socio);
                response.Data = socioDto;
                response.Success = true;
                response.StatusCode = System.Net.HttpStatusCode.OK;
            }
            else
            {
                response.SetError("No se encontro usuario con el id", System.Net.HttpStatusCode.InternalServerError);
            }
            return response;
        }
    }
}
