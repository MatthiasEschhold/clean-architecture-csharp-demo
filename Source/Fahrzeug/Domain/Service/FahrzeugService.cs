using CleanArchitectureDemo.Fahrzeug.Domain.Model;
using CleanArchitectureDemo.Fahrzeug.UseCase.In;
using CleanArchitectureDemo.Fahrzeug.UseCase.Out;

namespace CleanArchitectureDemo.Fahrzeug.Domain.Service
{
    public class FahrzeugService : FetchFahrzeug
    {
        private readonly FetchExternalFahrzeug fetchExternalFahrzeug;

        public FahrzeugService(FetchExternalFahrzeug fetchExternalFahrzeug)
        {
            this.fetchExternalFahrzeug = fetchExternalFahrzeug;
        }

        public FahrzeugEntity Fetch(string fahrgestellnummer)
        {
            return fetchExternalFahrzeug.Fetch(fahrgestellnummer);
        }
    }
}
