using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vehicleBooking.Models
{
    public class Booking
    {
        [Key]
        public long Id { get; set; }
        public string PickupLocation { get; set; }
        public string DropoffLocation { get; set; }
        public string? SpecialRequest { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public bool isCompleted { get; set; }
        public int? noOfHours { get; set; }
        public int? mileage { get; set; }
        public int? dayCharge { get; set; }

        //Relationships
        public Passenger passenger { get; set; }
        public long passengerId { get; set; }

        public Vehicle vehicle { get; set; }
        public long VehicleId { get; set;}

        public Chauffeur chauffeurs { get; set; }
        public long chauffeurId { get; set;}

        public Billing billing { get; set; }
        public Feedback feedback { get; set; }
    }
}
