using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using pet_hotel.Models;
using Microsoft.EntityFrameworkCore;

namespace pet_hotel.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PetOwnersController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public PetOwnersController(ApplicationContext context) {
            _context = context;
        }

        // This is just a stub for GET / to prevent any weird frontend errors that 
        // occur when the route is missing in this controller
        [HttpGet]
        public IEnumerable<PetOwner> GetAllOwners() {
            return _context.Owners;
        }

        [HttpGet("{id}")]
        public PetOwner GetOwner(int id) {
            Console.WriteLine($"This is the IDDDDDDD{id}");
            return _context.Owners.Find(id);
        }

        [HttpPost]
        public StatusCodeResult Post(PetOwner owner) {
            _context.Add(owner);
            _context.SaveChanges();
            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, PetOwner owner) {
            owner.id = id;
            _context.Update(owner);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            PetOwner owner = _context.Owners.Find(id);
            _context.Owners.Remove(owner);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
