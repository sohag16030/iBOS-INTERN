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

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddPersonTests(PersonTest personTest)
        {
            _personTestData.AddPersonTest(personTest);
            return Ok();

        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeletePersonTests(long id)
        {
            var person = _personTestData.GetPersonTest(id);
            if (person != null)
            {
                _personTestData.DeletePersonTest(person);
                return Ok();
            }
            return NotFound($"person with id {id} is Not Found");
        }

        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult EditPersonTest(long id, PersonTest personTest)
        {
            var existingPerson = _personTestData.GetPersonTest(id);
            if (existingPerson != null)
            {
                personTest.IntPersonId = existingPerson.IntPersonId;
                _personTestData.EditPersonTest(personTest);
            }

            return Ok(personTest);
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetPersonTests(long id)
        {
            var persontest = _personTestData.GetPersonTest(id);
            if (persontest != null)
                return Ok(persontest);
            return NotFound($"Person of Id {id} is not found");

        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetAllPersonTests()
        {
            return Ok(_personTestData.GetAllPersonTests());
        }
        
    }
}