using Microsoft.EntityFrameworkCore;

namespace vehicleBooking.Models
{
    public class Cost
    {
        
        public long CostPerMile { get; set; }
        public long HourlyRate { get; set; }
        public long DayCharge { get; set; }
    }
}
