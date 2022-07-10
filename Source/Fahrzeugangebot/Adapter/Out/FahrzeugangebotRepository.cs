using CleanArchitectureDemo.Source.Fahrzeugangebot.Domain.Model;
using CleanArchitectureDemo.Source.Fahrzeugangebot.UseCase.Out;

namespace CleanArchitectureDemo.Source.Fahrzeugangebot.Adapter.Out
{
    public class FahrzeugangebotRepository : FahrzeugangebotDbQuery, FahrzeugangebotDbCommand
    {
        public FahrzeugangebotEntity Read(string angebotsnummer)
        {
            return new FahrzeugangebotEntity();
        }

        public FahrzeugangebotEntity Save(FahrzeugangebotEntity fahrzeugangebot)
        {
            return new FahrzeugangebotEntity();
        }
    }
}
