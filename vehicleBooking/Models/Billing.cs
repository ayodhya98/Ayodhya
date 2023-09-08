using System.ComponentModel.DataAnnotations;
using vehicleBooking.Models.Enums;

namespace vehicleBooking.Models
{
    public class Billing
    {
        [Key]
        public long Id { get; set; }
        public PaymentType PaymentType { get; set; }
        public long TotalAmount { get; set; }
        public DateTime DateTime { get; set; }
        public bool PaymentStatus { get; set; }

       //Relationships
       public Passenger Passenger { get; set; }
       public long PassengerId { get; set; }
       public Booking booking { get; set; }
       public long bookingId { get; set; }

    }
}
