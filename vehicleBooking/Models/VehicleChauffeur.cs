namespace vehicleBooking.Models
{
    public class VehicleChauffeur
    {
        public long VehicleId { get; set; }
        public long ChauffeurId { get; set; }
        public Vehicle Vehicle { get; set; }
        public Chauffeur Chauffeur { get; set; }
    }
}
