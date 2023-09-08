using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vehicleBooking.Data;
using vehicleBooking.Models;
using vehicleBooking.Repository.Interfaces;

namespace vehicleBooking.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private readonly DataContext _context;

        public AdminRepository(DataContext context)
        {
            _context = context;
        }

        public bool CreateChauffeur(Chauffeur chauffeur)
        {
            _context.Add(chauffeur);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteChauffeur(long id)
        {
            var chauffeur = _context.Chauffeur.FirstOrDefault(c => c.Id == id);

            if (chauffeur != null)
            {
                _context.Chauffeur.Remove(chauffeur);
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public Chauffeur GetChauffeur(long id)
        {
            return _context.Chauffeur.FirstOrDefault(c => c.Id == id);
        }

        public List<Chauffeur> GetChauffeurs()
        { 
            List<Chauffeur> list =  _context.Chauffeur.ToList();
            return list;
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

        public Booking getBookingById(long id)
        {
            throw new NotImplementedException();
        }

        public List<Booking> GetBookings()
        {
            throw new NotImplementedException();
        }

        public Passenger GetPassenger(long id)
        {
            return _context.Passenger.FirstOrDefault(p => p.Id == id);
        }

        public List<Passenger> GetPassengers()
        {
            return _context.Passenger.ToList();
        }

        public Vehicle GetVehicle(long id)
        {
            throw new NotImplementedException();
        }

        public List<Vehicle> GetVehicles()
        {
            throw new NotImplementedException();
        }

        public bool UpdateChauffeur(Chauffeur chauffeur)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePassenger(Passenger passenger)
        {
            var existingPassenger = _context.Passenger.FirstOrDefault(p => p.Id == passenger.Id);

            if (existingPassenger != null)
            {
               
                existingPassenger.FirstName = passenger.FirstName;
                existingPassenger.LastName = passenger.LastName;
                existingPassenger.Email = passenger.Email;
                existingPassenger.AvailabilityStatus = passenger.AvailabilityStatus;
                existingPassenger.Gender = passenger.Gender;
                existingPassenger.PhoneNumber = passenger.PhoneNumber;

                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public List<Vehicle> ViewAvailableVehicles(bool status)
        {
            throw new NotImplementedException();
        }

        public Chauffeur UpdateAvailability(long chauffeurId, bool status)
        {
            var chauffeur = _context.Chauffeur.FirstOrDefault(c => c.Id == chauffeurId);

            if (chauffeur != null)
            {
                chauffeur.AvailabiltyStatus = status;
                _context.SaveChanges();
                return chauffeur;
            }
            return new Chauffeur();
        }

        public bool CreatePassenger(Passenger passenger)
        {
            throw new NotImplementedException();
        }
    }
}
