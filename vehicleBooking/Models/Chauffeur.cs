using System.ComponentModel.DataAnnotations;

namespace vehicleBooking.Models
{
    public class Chauffeur
    {
        [Key]
        public long Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Gender { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public bool AvailabiltyStatus { get; set; }

        [Required]
        public int phoneNumber { get; set; }

        //Relationships
        public List<Booking>? Bookings { get; set; }       
        public List<Feedback>? feedbacks { get; set; }
        public Company? company { get; set; }
        public long? companyId { get; set; }
        public List<VehicleChauffeur>? VehicleChauffeurs { get; set; }
    }
}
