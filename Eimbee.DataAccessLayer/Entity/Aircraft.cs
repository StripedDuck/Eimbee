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
         public DateTime first_flight_date{ get; set; } 
         public DateTime delivery_date{ get; set; } 
         public string plane_series{ get; set; } 
         public string airline_iata_code{ get; set; } 
         public string airline_icao_code{ get; set; } 
         public string plane_owner{ get; set; } 
         public string engines_type{ get; set; }
         public string plane_status{ get; set; }
        
    }
}
