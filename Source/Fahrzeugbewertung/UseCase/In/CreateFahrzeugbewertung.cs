using CleanArchitectureDemo.Source.Fahrzeugbewertung.Domain.Model;

namespace CleanArchitectureDemo.Source.Fahrzeugbewertung.UseCase.In
{
    public interface CreateFahrzeugbewertung
    {
        FahrzeugbewertungEntity Create(FahrzeugbewertungEntity fahrzeugbewertung);
    }
}
