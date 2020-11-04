using Eimbee.Core.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eimbee.DataAccessLayer.Entity
{
    public class Aircraft
    {
        [Key]
        public string RegistrationNumber { get; set; }
        public string IataType { get; set; }
        public string ModelName { get; set; }
        public string ModelCode { get; set; }
        public string IataCodeShort { get; set; }
        public string PlaneSeries { get; set; }
        public string AirlineIataCode { get; set; }
        public string EnginesType { get; set; }
        public AircraftStatus Status { get; set; }
        [ForeignKey("AirlineIataCode")]
        public Airline Airline { get; set; }

    }
}
