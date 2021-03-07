using FirstCrudeOperationUsingNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace FirstCrudeOperationUsingNetCore.Controllers
{
    [ApiController]
    public class PersonTestController : ControllerBase
    {
        private readonly IPersonTestData _personTestData;

        public PersonTestController(IPersonTestData personTestData)
        {
            _personTestData = personTestData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        //public IActionResult GetAllPersonTests()
        //{
        //    return Ok(_personTestData.GetAllPersonTests());
        //}
        //[HttpGet]
        //[Route("api/[controller]/{id}")]
        //public IActionResult GetPersonTests(long id)
        //{
        //    var persontest = _personTestData.GetPersonTest(id);
        //    if (persontest != null)
        //        return Ok(persontest);
        //    return NotFound($"Person of Id {id} is not found");

        //}
    }
}
