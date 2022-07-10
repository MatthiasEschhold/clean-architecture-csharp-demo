using CleanArchitectureDemo.Source.Fahrzeugangebot.Domain.Model;
using CleanArchitectureDemo.Source.Fahrzeugangebot.UseCase.In;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureDemo.Source.Fahrzeugangebot.Adapter.In
{
    public class FahrzeugangebotController : ControllerBase
    {
        private readonly CreateFahrzeugangebot createFahrzeugangebot;

        public FahrzeugangebotController(CreateFahrzeugangebot createFahrzeugangebot)
        {
            this.createFahrzeugangebot = createFahrzeugangebot;
        }

        [HttpPost(Name = "PostFahrzeugangebot")]
        public FahrzeugangebotResource CreateFahrzeugangebot(FahrzeugangebotResource fahrzeugangebotResource)
        {
            FahrzeugangebotEntity entity = createFahrzeugangebot.Create(new FahrzeugangebotEntity());
            return new FahrzeugangebotResource();
        }
    }
}
