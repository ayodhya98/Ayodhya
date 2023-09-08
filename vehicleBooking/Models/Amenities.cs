using System.ComponentModel.DataAnnotations;
using vehicleBooking.Models.Enums;

namespace vehicleBooking.Models
{
    public class Amenities
    {
        [Key]
        public long Id { get; set; }
        public AmenityType AmenityType { get; set; }
        public long Price { get; set; }

        //public List<Vehicle> vehicles { get; set; }
        public List<VehicleAmenities>? VehicleAmenities { get; set; }
    }
}
