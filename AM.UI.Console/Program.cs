// See https://aka.ms/new-console-template for more information

using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;

Console.WriteLine("Hello, World!");
//création d'un objet à travers le constructeur par défaut
Plane p = new Plane();
p.Capacity = 100;
Console.WriteLine(p.Capacity);
p.ManufactureDate = DateTime.Now;
p.PlaneType = PlaneType.Boeing;

//Flight f = new Flight("Paris","Tunis",new DateTime(2024,10,3,12,1,1)
//    , new DateTime(2024, 10, 3, 13, 1, 1),120);
//création d'un objet à travers l'initialiseur d'objets
Flight f = new Flight() { Departure = "Tunis" ,
                          Destination = "Paris",
                          EstimatedDuration=120,
                          FlightDate= new DateTime(2024, 10, 3, 12, 1, 1),
                          EffectiveArrival= new DateTime(2024, 10, 3, 13, 1, 1)
                        };
Console.WriteLine(f);
Console.WriteLine("*********CheckProfile********");
Passenger p1 = new Passenger() { FirstName="amina",
                                 LastName="aoun",
    EmailAdress = "amina.aoun@esprit.tn"
};
Console.WriteLine(p1.CheckProfile("Amina","Aoun"));
Console.WriteLine(p1.CheckProfile("Amina", "Aoun","abc"));
Console.WriteLine("*********Passenger Type********");
Staff s1 = new Staff();
Traveller t1= new Traveller();
p1.PassengerType();
s1.PassengerType();
t1.PassengerType();
Console.WriteLine("********GetFlightDates*****************");
FlightMethods fm=new FlightMethods();
fm.Flights = TestData.listFlights;
foreach(DateTime d in  fm.GetFlightDates("Paris"))
    Console.WriteLine(d);
Console.WriteLine("********GetFlights*****************");
fm.GetFlights("EstimatedDuration", "105");
Console.WriteLine("********ShowFlightDetails***********");
fm.ShowFlightDetails(TestData.Airbusplane);
fm.FlightDetailsDel(TestData.Airbusplane);
Console.WriteLine("*****ProgrammedFlightNumber*****");
Console.WriteLine(fm.ProgrammedFlightNumber(new DateTime(2021, 12, 31)));
Console.WriteLine("*****DurationAverage*****");
Console.WriteLine(fm.DurationAverage("Paris"));
Console.WriteLine(fm.DurationAverageDel("Paris"));
foreach (Flight fl in fm.OrderedDurationFlights())
    Console.WriteLine(fl.EstimatedDuration);
Console.WriteLine("*****SeniorTraveller*****");
foreach (Traveller t in fm.SeniorTravellers(TestData.flight1))
    Console.WriteLine(t.BirthDate);
Console.WriteLine("*****DestinationGroupedFlight*****");
fm.DestinationGroupedFlights();
Console.WriteLine("*****UpperFullName*****");
p1.UpperFullName();