using CleanArchitectureDemo.Source.Fahrzeugbewertung.Domain.Model;
using CleanArchitectureDemo.Source.Fahrzeugbewertung.UseCase.In;
using CleanArchitectureDemo.Source.Fahrzeugbewertung.UseCase.Out;

namespace CleanArchitectureDemo.Source.Fahrzeugbewertung.Domain.Service
{
    public class FahrzeugbewertungService : CreateFahrzeugbewertung
    {
        private readonly CreateExternalFahrzeugbewertung createExternalFahrzeugbewertung;


        public FahrzeugbewertungService(CreateExternalFahrzeugbewertung createExternalFahrzeugbewertung) 
        {
            this.createExternalFahrzeugbewertung = createExternalFahrzeugbewertung;       
        }

        public FahrzeugbewertungEntity Create(FahrzeugbewertungEntity fahrzeugbewertung)
        {
            return createExternalFahrzeugbewertung.Create(fahrzeugbewertung);
        }
    }
}
