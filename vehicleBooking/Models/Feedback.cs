using System.ComponentModel.DataAnnotations;

namespace vehicleBooking.Models
{
    public class Feedback
    {
        [Key]
        public long Id { get; set; }
        public string? PassengerComment { get; set; }
        public int? PassengerRating { get; set; }
        public int? ChauffeurRating { get; set; }
        public DateTime Date { get; set; }

        //Relationships
        public Passenger passenger { get; set; }
        public long PassengerId { get; set; }
        public Chauffeur chauffeur { get; set; }
        public long chauffeurId { get; set; }
        public Booking booking { get; set; }
        public long bookingId { get; set;}
        public Vehicle vehicle { get; set; }
        public long vehicleId { get; set; }
    
    }
}
