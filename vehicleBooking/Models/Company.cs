namespace vehicleBooking.Models
{
    public class Company
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string phoneNumber { get; set; }
        public string? description { get; set; }

        //Relationships
        public List<Chauffeur>? Chauffeurs { get; set; }

    }
}
