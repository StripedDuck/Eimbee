
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Eimbee.DataAccessLayer.Entity
{
    public class Airline
    {
        [Key]
        public string IcaoCode { get; set; }
        public string Callsign { get; set; }
        public string AirlineName { get; set; }
        public List<Aircraft> Aircrafts { get; set; }
            
    }
}
