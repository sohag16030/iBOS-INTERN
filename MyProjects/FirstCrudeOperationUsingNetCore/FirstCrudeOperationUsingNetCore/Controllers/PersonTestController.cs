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
        public IActionResult AddPersonTests(PersonTestCreateModel personTest)
        {
             PersonTest persontest = new PersonTest
             {
                    StrName = personTest.StrName,
                    StrAddress = personTest.StrAddress,
                    Age = personTest.Age
             };
             _personTestData.AddPersonTest(persontest);
            
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

        //[HttpPatch]
        //[Route("api/[controller]/{id}")]
        //public IActionResult EditPersonTest(long id, PersonTestEditModel personTest)
        //{
        //    var existingPerson = _personTestData.GetPersonTest(id);
        //    if (existingPerson != null)
        //    {
        //        _personTestData.EditPersonTest(personTest);
        //    }

        //    return Ok(personTest);
        //}

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetPersonTests(long id)
        {
            var persontest = _personTestData.GetPersonTest(id);
            if (persontest != null)
                return Ok(persontest);
            return NotFound($"Person of Id {id} is not found");

        }

        

    }
}