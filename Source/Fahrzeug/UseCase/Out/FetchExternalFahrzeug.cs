using CleanArchitectureDemo.Fahrzeug.Domain.Model;


namespace CleanArchitectureDemo.Fahrzeug.UseCase.Out
{
    public interface FetchExternalFahrzeug
    {
        FahrzeugEntity Fetch(string fahrgestellnummer);
    }
}
