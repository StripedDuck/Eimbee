using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eimbee.DataAccessLayer.Entity
{
    public class Airport
    {
        [Key]
        public string IataCode { get; set; }
        public string IcaoCode { get; set; }
        public string Name { get; set; }        
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string CityIataCode { get; set; }
        public string CountryIso2 { get; set; }
        [ForeignKey("CountryIso2")]
        public Country Country { get; set; }
        [ForeignKey("CityIataCode")]
        public City City { get; set; }
        

    }
}
