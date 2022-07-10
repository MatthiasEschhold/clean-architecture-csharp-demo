using CleanArchitectureDemo.Source.Fahrzeugbewertung.Domain.Model;
using CleanArchitectureDemo.Source.Fahrzeugbewertung.UseCase.In;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureDemo.Source.Fahrzeugbewertung.Adapter.In
{
    [ApiController]
    [Route("[controller]")]
    public class FahrzeugbewertungController : Controller
    {

        private readonly CreateFahrzeugbewertung createFahrzeugbewertung;

        [HttpPost(Name = "PostFahrzeugbewertung")]
        public FahrzeugbewertungResource CreateFahrzeugbewertung(FahrzeugbewertungResource fahrzeugbewertungResource)
        {
            FahrzeugbewertungEntity entity = createFahrzeugbewertung.Create(new FahrzeugbewertungEntity());
            return new FahrzeugbewertungResource();
        }
    }
}
