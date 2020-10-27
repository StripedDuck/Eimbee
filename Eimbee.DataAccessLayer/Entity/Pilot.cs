using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Eimbee.DataAccessLayer.Entity
{
    public class Pilot
    {
        [Key]
        public string Email { get; set; }
        public string Location { get; set; }
        public string VirtualAirline { get; set; }
        [ForeignKey("Location")]
        public Airport Airport { get; set; }
        [ForeignKey("VirtualAirline")]
        public Airline Airline { get; set; }

    }
}
