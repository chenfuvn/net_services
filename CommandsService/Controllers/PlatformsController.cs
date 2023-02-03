using System;
using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers
{
    [ApiController]
    [Route("api/c/[controller]")]
    public class PlatformsController : ControllerBase
    {
        public PlatformsController()
        {

        }

        [HttpPost]
        public ActionResult TestInboundConnection()
        {
            Console.WriteLine($"{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")} --> Inbound POST # Command Service");

            return Ok("Inbound test of from Platforms Controller");
        }

    }
}