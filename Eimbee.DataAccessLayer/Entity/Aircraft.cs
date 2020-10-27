using Eimbee.Core.Enums;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.ComponentModel.DataAnnotations;

namespace Eimbee.DataAccessLayer.Entity
{
    public class Aircraft
    {
        [Key]
        public string RegistrationNumber { get; set; } 
         public string ProductionLine{ get; set; } 
         public string IataType{ get; set; } 
         public string ModelName{ get; set; }
         public string ModelCode{ get; set; }
         public string IcaoCodeHex{ get; set; } 
         public string IataCodeShort{ get; set; } 
         public int ConstructionNumber{ get; set; }          
         public string PlaneSeries{ get; set; } 
         public string AirlineIataCode{ get; set; } 
         public string AirlineIcaoCode{ get; set; } 
         public string EnginesType{ get; set; }
         public AircraftStatus Status{ get; set; }
        
    }
}
