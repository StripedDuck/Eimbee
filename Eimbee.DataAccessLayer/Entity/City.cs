using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eimbee.DataAccessLayer.Entity
{
    public class City
    {
        [Key]
        public string IataCode { get; set; }
        public string Name { get; set; }
        [ForeignKey("CountryIso2")]
        public Country Country { get; set; }
        public string CountryIso2 { get; set; }        
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }        
    }
}
