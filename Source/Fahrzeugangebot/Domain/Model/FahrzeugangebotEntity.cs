using CleanArchitectureDemo.Fahrzeug.Domain.Model;

namespace CleanArchitectureDemo.Source.Fahrzeugangebot.Domain.Model
{
    public class FahrzeugangebotEntity
    {
        string Angebotsnummer { get; set; }
        FahrzeugEntity Fahrzeug { get; set; }
    }
}
