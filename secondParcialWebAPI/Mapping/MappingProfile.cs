using AutoMapper;
using secondParcialWebAPI.DTOS;
using secondParcialWebAPI.Models;

namespace secondParcialWebAPI.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<Socio, SocioDtoId>()
            .ForMember(dest => dest.socio_id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.soemail, opt => opt.MapFrom(src => src.Email))
            .ForMember(dest => dest.sonombre, opt => opt.MapFrom(src => src.Nombre))
            .ForMember(dest => dest.sodni, opt => opt.MapFrom(src => src.Dni));

            CreateMap<SocioDtoId,Socio>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.socio_id))
            .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.soemail))
            .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.sonombre))
            .ForMember(dest => dest.Dni, opt => opt.MapFrom(src => src.sodni));

            CreateMap<Socio, SocioAltaDto>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
            .ForMember(dest => dest.Activo, opt => opt.MapFrom(src => src.Activo))
            .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
            .ForMember(dest => dest.Apellido, opt => opt.MapFrom(src => src.Apellido))
            .ForMember(dest => dest.Dni, opt => opt.MapFrom(src => src.Dni))
            .ForMember(dest => dest.IdDeporte, opt => opt.MapFrom(src => src.IdDeporte))
            .ForMember(dest => dest.Telefono, opt => opt.MapFrom(src => src.Telefono))
            .ForMember(dest => dest.Calle, opt => opt.MapFrom(src => src.Calle))
            .ForMember(dest => dest.Numero, opt => opt.MapFrom(src => src.Numero))
            .ForMember(dest => dest.CodPost, opt => opt.MapFrom(src => src.CodPost))
            .ForMember(dest => dest.Provincia, opt => opt.MapFrom(src => src.Provincia))
            .ForMember(dest => dest.Ciudad, opt => opt.MapFrom(src => src.Ciudad))
            .ForMember(dest => dest.FechaAlta, opt => opt.MapFrom(src => src.FechaAlta));

            CreateMap<SocioAltaDto, Socio>()
           .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
           .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
           .ForMember(dest => dest.Activo, opt => opt.MapFrom(src => src.Activo))
           .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
           .ForMember(dest => dest.Apellido, opt => opt.MapFrom(src => src.Apellido))
           .ForMember(dest => dest.Dni, opt => opt.MapFrom(src => src.Dni))
           .ForMember(dest => dest.IdDeporte, opt => opt.MapFrom(src => src.IdDeporte))
           .ForMember(dest => dest.Telefono, opt => opt.MapFrom(src => src.Telefono))
           .ForMember(dest => dest.Calle, opt => opt.MapFrom(src => src.Calle))
           .ForMember(dest => dest.Numero, opt => opt.MapFrom(src => src.Numero))
           .ForMember(dest => dest.CodPost, opt => opt.MapFrom(src => src.CodPost))
           .ForMember(dest => dest.Provincia, opt => opt.MapFrom(src => src.Provincia))
           .ForMember(dest => dest.Ciudad, opt => opt.MapFrom(src => src.Ciudad))
           .ForMember(dest => dest.FechaAlta, opt => opt.MapFrom(src => src.FechaAlta));

            CreateMap<Socio, SocioDto>()
            .ForMember(dest => dest.id_socio, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.nombreso, opt => opt.MapFrom(src => src.Nombre))
            .ForMember(dest => dest.apellidoso, opt => opt.MapFrom(src => src.Apellido))
            .ForMember(dest => dest.dniso, opt => opt.MapFrom(src => src.Dni))
            .ForMember(dest => dest.deporte_id, opt => opt.MapFrom(src => src.IdDeporte));

            CreateMap<SocioDto, Socio>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id_socio))
            .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.nombreso))
            .ForMember(dest => dest.Apellido, opt => opt.MapFrom(src => src.apellidoso))
            .ForMember(dest => dest.Dni, opt => opt.MapFrom(src => src.dniso))
            .ForMember(dest => dest.IdDeporte, opt => opt.MapFrom(src => src.deporte_id));

            CreateMap<Deporte, DeporteDto>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.nombreDeporte, opt => opt.MapFrom(src => src.Nombre))
            .ForMember(dest => dest.Descripcion, opt => opt.MapFrom(src => src.Descripcion));

        }

    }
}
