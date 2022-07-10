using CleanArchitectureDemo.Source.Fahrzeugangebot.Domain.Model;

namespace CleanArchitectureDemo.Source.Fahrzeugbewertung.Domain.Model
{
    public class FahrzeugbewertungEntity
    {
        string Bewertungsnummer { get; set; }   
        FahrzeugangebotEntity fahrzeugangebot { get; set; }
    }
}
