using System.ComponentModel.DataAnnotations;

namespace Eimbee.DataAccessLayer.Entity
{
    public class AircraftType
    {
        [Key]
        public int IataCode { get; set; }
        public string Name { get; set; }            
    }
}
