using GuestList.Models;
using GuestList.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace GuestList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : Controller
    {
        private readonly MicroDatabaseService _database;

        public GuestController(MicroDatabaseService dateTime)
        {
            _database = dateTime;
        }
        // GET: GuestController/GetGuest/5  
        [HttpGet("GetGuest/{id}")]
        public ActionResult GetGuest(int id)
        {
            var data = _database.ReturnGuest(id);    
            return Ok(data);
        }
        [HttpGet("GetAllGuests")]
        public ActionResult ReturnAllGuests()
        {
            var data = _database.ReturnAllGuests();
            return Ok(data);
        }

        [HttpPost("AddNewGuest")]
        public ActionResult AddNewGuest(Guest guest)
        {

            _database.AddNewGuest(guest);
            return Ok();
              
        }
        [HttpPost("[action]")]
        public ActionResult DeleteUser(int id)
        {
            _database.DeleteGuest(id);
            return Ok();
        }




    }
}

