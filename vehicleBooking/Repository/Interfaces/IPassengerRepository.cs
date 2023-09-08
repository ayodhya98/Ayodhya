using vehicleBooking.Models;

namespace vehicleBooking.Repository.Interfaces
{
    public interface IPassengerRepository
    {
        void CreatePassenger(Passenger passenger);
        List<Passenger> GetPassengers();
        Passenger GetPassenger(long id);
        bool UpdatePassenger(Passenger passenger);
        bool DeletePassenger(long id);
        Passenger UpdatePassengerAvailability(long passengerId, bool status);

    }
}
