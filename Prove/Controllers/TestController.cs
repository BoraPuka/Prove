using Microsoft.AspNetCore.Mvc;
using Prove.Data.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prove.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : Controller
    {
        private testService _service;
        public TestController(testService service)
        {
            _service = service;
        }
        [HttpPost("add-new-record")]
        public IActionResult AddNewRecord([FromBody] string name)
        {
            _service.AddTest(name);
            return Ok();
        }
    }
}
