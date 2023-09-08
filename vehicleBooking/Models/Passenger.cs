using System.ComponentModel.DataAnnotations;

namespace vehicleBooking.Models
{
    public class Passenger
    {
        [Key]
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }



        //Relationships
        public List<Billing> billings { get; set; }
        public List<Feedback> feedbacks { get; set; }
        public List<Booking> bookings { get; set; }
        public bool AvailabilityStatus { get; internal set; }
    }
}
