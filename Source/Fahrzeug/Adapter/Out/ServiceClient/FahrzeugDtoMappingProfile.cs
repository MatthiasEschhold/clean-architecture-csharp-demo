using AutoMapper;
using CleanArchitectureDemo.Fahrzeug.Domain.Model;

namespace CleanArchitectureDemo.Fahrzeug.Adapter.Out.ServiceClient
{
    public class FahrzeugDtoMappingProfile : Profile
    {
        public FahrzeugDtoMappingProfile()
        {
            CreateMap<FahrzeugEntity, VehicleDto>().ReverseMap();
            CreateMap<FahrzeugEntity, VehicleDto>()
                .ForMember(dest => dest.Vin, opt => opt.MapFrom(s => s.Fahrgestellnummer))
                .ForMember(dest => dest.ModelType, opt => opt.MapFrom(s => s.Fahrzeugmodell))
                .ForMember(dest => dest.Mileage, opt => opt.MapFrom(s => s.Kilometerstand));

        }
    }
}
