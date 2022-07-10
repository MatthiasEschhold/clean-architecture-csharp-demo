using AutoMapper;

using CleanArchitectureDemo.Fahrzeug.Domain.Model;
using CleanArchitectureDemo.Fahrzeug.UseCase.Out;

namespace CleanArchitectureDemo.Fahrzeug.Adapter.Out.ServiceClient
{
    public class FahrzeugServiceClient : FetchExternalFahrzeug
    {
        private static readonly MapperConfiguration Config = new(cfg => {
            cfg.AddProfile<FahrzeugDtoMappingProfile>();
        });

        private Mapper mapper;

        public FahrzeugServiceClient()
        {
            mapper = new Mapper(Config);
        }

        public FahrzeugEntity Fetch(string fahrgestellnummer)
        {
            var vehicleDto = new VehicleDto(); //call from a external service
            return mapper.Map<FahrzeugEntity>(vehicleDto);
        }
    }
}
