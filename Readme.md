# Agile Produktlinienarchitektur mit der Clean Architecture - Codebeispiele zur Artikelserie

## Zur Artikelserie

* [Zu Teil 1 - WIP]()
* [Zu Teil 2 - WIP]()


Am Beispiel der Root Entity Fahrzeug wird das Clean Architecture Pattern veranschaulicht. Die Strukturierung des Module Fahrzeug ist
architektonisch ausdrucksstark abgebildet. Für das Mapping wird die Two-Way Mapping Strategie eingesetzt.

## Mappings mit AutoMapper

Library: [AutoMapper](https://github.com/AutoMapper/AutoMapper)

### Simples Mapping zwischen Domäne und der Infrastrukturkomponente Web

Die Two-Way Mapping Strategie kann auf Basis einer einfachen Konfiguration realisiert werden, wenn die Klasseneigenschaften den gleichen Namen haben.
Diés ist der Fall auf Beispiel FahrzeugEntity und FahrzeugResource.

```csharp
public class FahrzeugEntity
    {
        public string Fahrgestellnummer { get; set; }
        public string Fahrzeugmodell { get; set; }
        public double Kilometerstand { get; set; }
    }
```

```csharp
public class FahrzeugResource
    {
        public string Fahrgestellnummer { get; set; }
        public string Fahrzeugmodell { get; set; }
        public double Kilometerstand { get; set; }
    }
```

Ein Mapper ganz in diesem Szenario durch eine einfach Konfiguration erstellt werden.

```csharp
public class FahrzeugController
    {
        private readonly FetchFahrzeug fetchFahrzeug;

        private static readonly MapperConfiguration Config = new(cfg => cfg.CreateMap<FahrzeugEntity, FahrzeugResource>());
        private Mapper mapper;

        public FahrzeugController()
        {
            fetchFahrzeug = new FahrzeugService();
            mapper = new Mapper(Config);
        }

        public FahrzeugResource GetFahrzeug(string id)
        {
            var fahrzeug = fetchFahrzeug.FetchFahrzeug(id);
            return mapper.Map<FahrzeugResource>(fahrzeug);
        }

    }
```

### Erweiteres Mapping zwischen Domäne und der Infrastrukturkomponente ServiceClient

Besteht keine Namensgleichheit, kann durch ein sogenanntes Profile, das Mapping angepasst werden. Auch Möglichkeiten für Defaults, etc. sind möglich. Ein einfach Konfiguration für die Objekte FahrzeugEntity und VehicleDto wird im folgenden gezeigt.

```csharp
public class VehicleDto
    {
        public string Vin { get; set; }
        public string ModelType { get; set; }
        public double Mileage { get; set; }
    }
```

Hierfür muss ein Profile von AutoMapper erstellt werden.

```csharp
using AutoMapper;

//...

public class FahrzeugDtoMappingProfile : Profile
    {
        public FahrzeugDtoMappingProfile()
        {
            CreateMap<FahrzeugEntity, VehicleDto>().ReverseMap();
            CreateMap<FahrzeugEntity, VehicleDto>()
                .ForMember(dest => dest.Vin, opt => opt.MapFrom(s => s.Fahrgestellnummer))
                .ForMember(dest => dest.ModelType, opt => opt.MapFrom(s => s.Fahrzeugmodell))
                .ForMember(dest => dest.Mileage, opt => opt.MapFrom(s => s.Kilometerstand));

        }
    }
```
