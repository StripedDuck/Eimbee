
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Eimbee.DataAccessLayer.Entity
{
    public class Airline
    {
        [Key]
        public string Callsign { get; set; }
        public string AirlineName { get; set; }
            
    }
}
