using Microsoft.AspNetCore.Mvc;
using vehicleBooking.Models.DTOs;
using vehicleBooking.Models;
using vehicleBooking.Repository.Interfaces;

namespace vehicleBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengerController : Controller
    {
        private readonly IPassengerRepository _repository;

        public PassengerController(IPassengerRepository repository)
        {
            _repository = repository;
        }


        [HttpPost]
        public IActionResult CreatePassenger(PassengerDto passengerDto)
        {
            var passenger = new Passenger
            {
                FirstName = passengerDto.FirstName,
                LastName = passengerDto.LastName,
                PhoneNumber = passengerDto.PhoneNumber,
                Gender = passengerDto.Gender,
                Email = passengerDto.Email,
                Password = passengerDto.Password,
               
            };

            _repository.CreatePassenger(passenger);
            return Ok(passenger);
        }

        [HttpGet]
        public IActionResult GetAllPassengers()
        {
            var passengers = _repository.GetPassengers();
            return Ok(passengers);
        }

        [HttpGet("{id}")]
        public IActionResult GetPassengerById(long id)
        {
            var passenger = _repository.GetPassenger(id);

            if (passenger == null)
            {
                return NotFound();
            }

            return Ok(passenger);
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePassenger(long id, Passenger passenger)
        {
            var result = _repository.UpdatePassenger(passenger);

            if (result)
            {
                return Ok();
            }

            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePassenger(long id)
        {
            var result = _repository.DeletePassenger(id);

            if (result)
            {
                return Ok();
            }

            return NotFound();
        }

        [HttpPatch("{id}/deactivate")]
        public IActionResult DeactivatePassenger(long id)
        {
            var result = _repository.UpdatePassengerAvailability(id, false);

            if (result != null)
            {
                return Ok(result);
            }

            return NotFound();
        }

    }
}
