using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPApplication1.Controllers
{
    public class IPController : ControllerBase
    {
        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            
            return Ok(HttpContext.Connection.LocalIpAddress.MapToIPv4().ToString());
        }
    }
}
