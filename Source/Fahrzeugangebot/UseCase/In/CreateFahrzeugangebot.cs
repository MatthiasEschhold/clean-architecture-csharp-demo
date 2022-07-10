using CleanArchitectureDemo.Source.Fahrzeugangebot.Domain.Model;

namespace CleanArchitectureDemo.Source.Fahrzeugangebot.UseCase.In
{
    public interface CreateFahrzeugangebot
    {
        FahrzeugangebotEntity Create(FahrzeugangebotEntity fahrzeugangebot);
    }
}
