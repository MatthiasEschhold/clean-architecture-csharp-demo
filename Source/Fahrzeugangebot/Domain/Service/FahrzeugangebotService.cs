using CleanArchitectureDemo.Source.Fahrzeugangebot.Adapter.Out;
using CleanArchitectureDemo.Source.Fahrzeugangebot.Domain.Model;
using CleanArchitectureDemo.Source.Fahrzeugangebot.UseCase.In;
using CleanArchitectureDemo.Source.Fahrzeugangebot.UseCase.Out;

namespace CleanArchitectureDemo.Source.Fahrzeugangebot.Domain.Service
{
    public class FahrzeugangebotService : CreateFahrzeugangebot, ReadFahrzeugangebot
    {

        private readonly FahrzeugangebotDbQuery dbQuery;
        private readonly FahrzeugangebotDbCommand dbCommand;

        public FahrzeugangebotService(FahrzeugangebotDbQuery dbQuery, FahrzeugangebotDbCommand dbCommand)
        {
            this.dbQuery = dbQuery;
            this.dbCommand = dbCommand;
        }

        public FahrzeugangebotEntity Create(FahrzeugangebotEntity fahrzeugangebot)
        {
            return dbCommand.Save(fahrzeugangebot);
        }

        public FahrzeugangebotEntity Read(string angebotsnummer)
        {
            FahrzeugangebotDbEntity dbEntity = new FahrzeugangebotDbEntity();
            return dbQuery.Read(angebotsnummer);
        }
    }
}
