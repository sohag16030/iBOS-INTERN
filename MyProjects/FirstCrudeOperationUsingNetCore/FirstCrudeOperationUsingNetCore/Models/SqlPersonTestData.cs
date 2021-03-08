using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace FirstCrudeOperationUsingNetCore.Models
{
    public class SqlPersonTestData : IPersonTestData
    {
        private readonly RNDContext _context;

        public SqlPersonTestData(RNDContext context)
        {
            _context = context;
        }

        public PersonTest AddPersonTest(PersonTest personTest)
        {
            _context.PersonTest.Add(personTest);
            _context.SaveChanges();
            return personTest;
        }

        public void DeletePersonTest(PersonTest personTest)
        {
            _context.PersonTest.Remove(personTest);
            _context.SaveChanges();

        }

        //public PersonTest EditPersonTest(PersonTest personTest)
        //{
        //    var existingPerson = _context.PersonTest.Find(personTest.IntPersonId);
        //    if (existingPerson != null)
        //    {
        //        existingPerson.IntPersonId = personTest.IntPersonId;
        //        existingPerson.StrName = personTest.StrName;
        //        existingPerson.Age = personTest.Age;
        //        _context.PersonTest.Update(existingPerson);
        //        _context.SaveChanges();
        //    }
        //    return personTest;
        //}
        public PersonTest GetPersonTest(long id)
        {
            var person = _context.PersonTest.SingleOrDefault(x => x.IntPersonId == id);
            return person;
        }
        public List<PersonTest> GetAllPersonTests()
        {
            return _context.PersonTest.ToList();
        }
        public void ExecuteStoreProcedure()
        {

        }
    }
}
