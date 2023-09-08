using vehicleBooking.Models;

namespace vehicleBooking.Repository.Interfaces
{
    public interface IAdminRepository
    {
        bool CreateChauffeur(Chauffeur chauffeur);
        List<Passenger> GetPassengers();
        Passenger GetPassenger(long id);
        bool UpdatePassenger(Passenger passenger);
        bool DeletePassenger(long id);
        List<Chauffeur> GetChauffeurs();
        Chauffeur GetChauffeur(long id);
        bool UpdateChauffeur(Chauffeur chauffeur);  
        bool DeleteChauffeur(long id);
        Chauffeur UpdateAvailability(long chauffeurId, bool status);
        
        Booking getBookingById (long id);
        List<Booking> GetBookings();
        List<Vehicle> GetVehicles();
        Vehicle GetVehicle(long id);
        List<Vehicle> ViewAvailableVehicles(bool status);

    }
}
