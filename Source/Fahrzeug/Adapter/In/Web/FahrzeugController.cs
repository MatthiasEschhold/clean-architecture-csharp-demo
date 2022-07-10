using AutoMapper;
using Microsoft.AspNetCore.Mvc;

using CleanArchitectureDemo.Fahrzeug.UseCase.In;
using CleanArchitectureDemo.Fahrzeug.Domain.Model;

namespace CleanArchitectureDemo.Fahrzeug.Adapter.In.Web
{
    [ApiController]
    [Route("[controller]")]
    public class FahrzeugController : ControllerBase
    {
        private readonly FetchFahrzeug fetchFahrzeug;
        private readonly ILogger<FahrzeugController> logger;

        private static readonly MapperConfiguration Config = new(cfg => cfg.CreateMap<FahrzeugEntity, FahrzeugResource>());
        private Mapper mapper;

        public FahrzeugController(FetchFahrzeug fetchFahrzeug, ILogger<FahrzeugController> logger)
        {
            this.fetchFahrzeug = fetchFahrzeug;
            this.mapper = new Mapper(Config);
            this.logger = logger;
        }

        [HttpGet(Name = "GetFahrzeug")]
        public FahrzeugResource GetFahrzeug(string id)
        {
            var fahrzeug = fetchFahrzeug.Fetch(id);
            return mapper.Map<FahrzeugResource>(fahrzeug);
        }

    }
}
