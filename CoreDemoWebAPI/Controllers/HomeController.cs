using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDemoModels.DomainModels;
using CoreDemoService.SDI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemoWebAPI.Controllers
{
    [Produces("application/json")]
    public class HomeController : Controller
    {
        private readonly ISDICoreDemo _sdiCoreDemo;
        public HomeController(ISDICoreDemo sDICoreDemo)
        {
            _sdiCoreDemo = sDICoreDemo;
        }
        [HttpGet]
        [Route("api/Home/{name}")]
        public async Task<IActionResult> HelloWorld(string name)
        {
            return Ok("Hello " + name + "!!!");
        }

        [HttpGet("api/GetAllDepartment")]
        public async Task<IEnumerable<Depertment>> GetDepertments()
        {
            return await _sdiCoreDemo.Departments.GetAll();
        }

    }
}