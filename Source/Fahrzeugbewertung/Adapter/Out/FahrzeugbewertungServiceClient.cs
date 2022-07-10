using CleanArchitectureDemo.Source.Fahrzeugbewertung.Domain.Model;
using CleanArchitectureDemo.Source.Fahrzeugbewertung.UseCase.Out;

namespace CleanArchitectureDemo.Source.Fahrzeugbewertung.Adapter.Out
{
    public class FahrzeugbewertungServiceClient : CreateExternalFahrzeugbewertung
    {
        public FahrzeugbewertungEntity Create(FahrzeugbewertungEntity fahrzeugbewertung)
        {
            return new FahrzeugbewertungEntity();
        }
    }
}
