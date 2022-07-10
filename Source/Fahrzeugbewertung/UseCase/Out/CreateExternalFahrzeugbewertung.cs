using CleanArchitectureDemo.Source.Fahrzeugbewertung.Domain.Model;

namespace CleanArchitectureDemo.Source.Fahrzeugbewertung.UseCase.Out
{
    public interface CreateExternalFahrzeugbewertung
    {
        FahrzeugbewertungEntity Create(FahrzeugbewertungEntity fahrzeugbewertung);
    }
}
