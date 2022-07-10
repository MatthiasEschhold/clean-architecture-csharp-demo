using CleanArchitectureDemo.Source.Fahrzeugangebot.Domain.Model;

namespace CleanArchitectureDemo.Source.Fahrzeugangebot.UseCase.Out
{
    public interface FahrzeugangebotDbQuery
    {
        FahrzeugangebotEntity Read(String angebotsnummer);
    }
}
