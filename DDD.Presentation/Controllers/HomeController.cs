using DDD.Domain.AggregateModel.OrderModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public HomeController()
        {
                
        }

        [HttpGet("")]
        public async Task<IActionResult> Get()
        {
            Address address = new() { City = "AYDIN", Town = "Efeler" };

            OrderHead orderHead = new(0,"ok","test",DateTime.Now.AddHours(1), address, null);

            return Ok();
        }
    }
}
