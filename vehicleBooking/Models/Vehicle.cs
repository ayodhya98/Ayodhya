using System.ComponentModel.DataAnnotations;
using vehicleBooking.Models.Enums;

namespace vehicleBooking.Models
{
    public class Vehicle
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public int SeatingCapacity { get; set; }
        public VehicleType Type { get; set; }
        public string City { get; set; }
        public string? Location { get; set; }
        public bool Availablity { get; set; } = true;
        public VehicleBrand Brand { get; set; }

        //Relationships
        public List<Booking>? bookings { get; set; }
        //public Chauffeur chauffeur { get; set; }
        //public long chauffeurId { get; set; }

        //public List<Amenities> amenities { get; set; }
        public List<VehicleAmenities>? VehicleAmenities { get; set; }
        public List<VehicleChauffeur>? VehicleChauffeurs { get; set; }

        public List<Feedback>? Feedbacks { get; set;}


    }
}
