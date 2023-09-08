using System.ComponentModel.DataAnnotations;

namespace vehicleBooking.Models.DTOs
{
    public class ChauffeurDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Gender { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

        [Required]
        public int phoneNumber { get; set; }
    }
}
