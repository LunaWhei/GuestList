using GuestList.Models;
using GuestList.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace GuestList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : Controller
    {
        private readonly MicroDatabaseService microDatabaseService = new MicroDatabaseService();

        // GET: GuestController/GetGuest/5  
        [HttpGet("[action]")]
        public ActionResult GetGuest(int id)
        {
            var data = microDatabaseService.ReturnGuest(id);    
            return Ok(data);
        }
        public ActionResult ReturnAllGuests()
        {
            var data = microDatabaseService.ReturnAllGuests();
            return Ok(data);
        }

        [HttpGet("[action]")]
        public ActionResult AddNewGuest(Guest guest)
        {
            Task task = new Task(()=> microDatabaseService.AddNewGuest(guest));
            task.Wait();
            return Ok();      
        }
        [HttpPost("[action]")]
        public ActionResult DeleteUser(int id)
        {
            microDatabaseService.DeleteGuest(id);
            return Ok();
        }




    }
}

