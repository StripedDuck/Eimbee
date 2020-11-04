using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eimbee.DataAccessLayer.Entity
{
    public class AirlineRoute
    {
        [Key]
        public string FlightNumber { get; set; }
        public string AirlineIcaoCode { get; set; }        
        public string DepartureAirportIcaoCode { get; set; }
        public string ArrivalAirportIcaoCode { get; set; }                     
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }
        [ForeignKey("ArrivalAirportIcaoCode")]
        public Airport ArrivalAirport { get; set; }
        [ForeignKey("DepartureAirportIcaoCode")]
        public Airport DepartureAirport { get; set; }
        [ForeignKey("AirlineIcaoCode")]
        public Airline Airline { get; set; }
        public List<AirlineRoute> AirlineRoutes { get; set; }        

    }
}
