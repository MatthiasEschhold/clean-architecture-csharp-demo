using CleanArchitectureDemo.Source.Fahrzeugangebot.Domain.Model;

namespace CleanArchitectureDemo.Source.Fahrzeugangebot.UseCase.In
{
    public interface ReadFahrzeugangebot
    {
        FahrzeugangebotEntity Read(String angebotsnummer);
    }
}
