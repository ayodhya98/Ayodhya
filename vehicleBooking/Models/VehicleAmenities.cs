namespace vehicleBooking.Models
{
    public class VehicleAmenities
    {
        public long VehicleId { get; set; } 
        public long AmenityId { get; set; }
        public Vehicle Vehicle { get; set; }
        public Amenities Amenities { get; set; }
    }
}
