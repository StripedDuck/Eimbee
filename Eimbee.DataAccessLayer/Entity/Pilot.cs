using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Eimbee.Core.Enums;

namespace Eimbee.DataAccessLayer.Entity
{
    public class Pilot
    {
        [Key]
        public string Email { get; set; }
        public string Location { get; set; }
        public Role Role { get; set; }
        public Rank Rank { get; set; }
        public string VirtualAirline { get; set; }
        [ForeignKey("Location")]
        public Airport Airport { get; set; }
        [ForeignKey("VirtualAirline")]
        public Airline Airline { get; set; }
    }
}
