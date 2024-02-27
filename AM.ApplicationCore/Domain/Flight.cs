using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string AirlineLogo { get; set; }
        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration { get; set; }
        //objets de navigation
        public Plane Plane { get; set; }
        //foreignkey (ism l objet)
        //kan jyna amlin public Plane Pl{ get; set; }==> [ForeignKey("Pl")]
        [ForeignKey("Plane")]
        public int PlaneFK { get; set; }
        public ICollection<Passenger> Passengers { get; set; }
        public override string ToString()
        {
            return "Departure: " + Departure + " Destination: " + Destination
                + " Flight Date: " + FlightDate;
        }


    }
}
