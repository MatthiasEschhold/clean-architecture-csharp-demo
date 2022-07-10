using CleanArchitectureDemo.Source.Fahrzeugangebot.Domain.Model;

namespace CleanArchitectureDemo.Source.Fahrzeugangebot.UseCase.Out
{
    public interface FahrzeugangebotDbCommand
    {
        FahrzeugangebotEntity Save(FahrzeugangebotEntity fahrzeugangebot);
    }
}
