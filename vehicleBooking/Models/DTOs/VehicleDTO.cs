using vehicleBooking.Models.Enums;

namespace vehicleBooking.Models.DTOs
{
    public class VehicleDTO
    {
        public string Name { get; set; }
        public int SeatingCapacity { get; set; }
        public VehicleType Type { get; set; }
        public string City { get; set; }
        public string? Location { get; set; }
        public bool Availablity { get; set; } = true;
        public VehicleBrand Brand { get; set; }
    }
}
