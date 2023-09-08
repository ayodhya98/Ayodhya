using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using vehicleBooking.Models;
using vehicleBooking.Models.DTOs;
using vehicleBooking.Repository;
using vehicleBooking.Repository.Interfaces;


namespace vehicleBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminRepository _repository;

        public AdminController(IAdminRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public async Task<ActionResult<Chauffeur>> CreateChauffeur(ChauffeurDto chauffeurDto)
        {
            var Chauffeur = new Chauffeur
            {
                FirstName = chauffeurDto.FirstName,
                LastName = chauffeurDto.LastName,
                Gender = chauffeurDto.Gender,
                Email = chauffeurDto.Email,
                Password = chauffeurDto.Password,
            };

            _repository.CreateChauffeur(Chauffeur);
            return Ok(Chauffeur);
        }

        [HttpGet]
        public async Task<ActionResult<List<Chauffeur>>> GetAllChauffeurs()
        {
            return _repository.GetChauffeurs();
        }

        [HttpPatch]
        public Chauffeur UpdateAvailabilty(long id, bool status)
        {
            return _repository.UpdateAvailability(id, status);
        }

        [HttpGet("chauffeurs")]
        public IActionResult GetChauffeurs()
        {
            var chauffeurs = _repository.GetChauffeurs();
            return Ok(chauffeurs);
        }

        public IActionResult GetChauffeurById(long id)
        {
            var chauffeur = _repository.GetChauffeur(id);

            if (chauffeur == null)
            {
                return NotFound();
            }

            return Ok(chauffeur);
        }

        [HttpPost("chauffeurs")]
        public IActionResult CreateChauffeur(Chauffeur chauffeur)
        {
            var result = _repository.CreateChauffeur(chauffeur);

            if (result)
            {
                return Ok();
            }

            return BadRequest();
        }

        [HttpPut("chauffeurs/{id}")]
        public IActionResult UpdateChauffeur(long id, Chauffeur chauffeur)
        {
            var result = _repository.UpdateChauffeur(chauffeur);

            if (result)
            {
                return Ok();
            }

            return BadRequest();
        }

        [HttpDelete("chauffeurs/{id}")]
        public IActionResult DeleteChauffeur(long id)
        {
            var result = _repository.DeleteChauffeur(id);

            if (result)
            {
                return Ok();
            }

            return NotFound();
        }

        [HttpPut("chauffeurs/{id}/deactivate")]
        public IActionResult DeactivateChauffeur(long id)
        {
            var result = _repository.UpdateAvailability(id, false);

            if (result != null)
            {
                return Ok(result);
            }

            return NotFound();
        }

        [HttpPost("passengers")]
        public IActionResult CreatePassenger(Passenger passenger)
        {
            var result = _repository.CreatePassenger(passenger);

            if (result)
            {
                return Ok();
            }

            return BadRequest();
        }

        [HttpGet("passengers")]
        public IActionResult GetPassengers()
        {
            var passengers = _repository.GetPassengers();
            return Ok(passengers);
        }

        [HttpGet("passengers/{id}")]
        public IActionResult GetPassengerById(long id)
        {
            var passenger = _repository.GetPassenger(id);

            if (passenger == null)
            {
                return NotFound();
            }

            return Ok(passenger);
        }

        [HttpPut("passengers/{id}")]
        public IActionResult UpdatePassenger(long id, Passenger passenger)
        {
            var result = _repository.UpdatePassenger(passenger);

            if (result)
            {
                return Ok();
            }

            return BadRequest();
        }

        [HttpDelete("passengers/{id}")]
        public IActionResult DeletePassenger(long id)
        {
            var result = _repository.DeletePassenger(id);

            if (result)
            {
                return Ok();
            }

            return NotFound();
        }
    }
}
