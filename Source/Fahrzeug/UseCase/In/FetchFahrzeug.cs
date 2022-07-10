using CleanArchitectureDemo.Fahrzeug.Domain.Model;

namespace CleanArchitectureDemo.Fahrzeug.UseCase.In
{
    public interface FetchFahrzeug
    {
        public FahrzeugEntity Fetch(string fahrgestellnummer);
    }
}
