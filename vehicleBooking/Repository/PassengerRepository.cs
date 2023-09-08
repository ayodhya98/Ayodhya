using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using vehicleBooking.Data;
using vehicleBooking.Models;
using vehicleBooking.Repository.Interfaces;

namespace vehicleBooking.Repository
{
    public class PassengerRepository : IPassengerRepository
    {
        private readonly DataContext _context;

        public PassengerRepository(DataContext context)
        {
            _context = context;
        }

        public void CreatePassenger(Passenger passenger)
        {
            _context.Add(passenger);
            _context.SaveChanges();
        }

        public bool DeletePassenger(long id)
        {
            var passenger = _context.Passenger.FirstOrDefault(p => p.Id == id);

            if (passenger != null)
            {
                _context.Passenger.Remove(passenger);
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public Passenger GetPassenger(long id)
        {
            return _context.Passenger.FirstOrDefault(p => p.Id == id);
        }

        public List<Passenger> GetPassengers()
        {
            return _context.Passenger.ToList();
        }

        public bool UpdatePassenger(Passenger passenger)
        {
            var existingPassenger = _context.Passenger.FirstOrDefault(p => p.Id == passenger.Id);

            if (existingPassenger != null)
            {
                
                existingPassenger.FirstName = passenger.FirstName;
                existingPassenger.LastName = passenger.LastName;
                existingPassenger.PhoneNumber = passenger.PhoneNumber;
                existingPassenger.Gender = passenger.Gender;
                existingPassenger.Email = passenger.Email;
                existingPassenger.Password = passenger.Password;

                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public Passenger UpdatePassengerAvailability(long passengerId, bool status)
        {
            var passenger = _context.Passenger.FirstOrDefault(p => p.Id == passengerId);

            if (passenger != null)
            {
                passenger.AvailabilityStatus = status;
                _context.SaveChanges();
                return passenger;
            }

            return null;
        }
    }
}
