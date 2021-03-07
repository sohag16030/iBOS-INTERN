using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace FirstCrudeOperationUsingNetCore.Models
{
    public class SqlPersonTestData : IPersonTestData
    {
        private readonly MyDbContext _context;
        public SqlPersonTestData(MyDbContext context)
        {
            _context = context;
        }
        public PersonTest AddPersonTest(PersonTest personTest)
        {
            personTest.IntPersonId = 4;
            _context.PersonTest.Add(personTest);
            _context.SaveChanges();
            return personTest;
        }

        public void DeletePersonTest(PersonTest personTest)
        { 
            _context.PersonTest.Remove(personTest);
            _context.SaveChanges();

        }

        public PersonTest EditPersonTest(PersonTest personTest)
        {
            var existingPerson = _context.PersonTest.Find(personTest.IntPersonId);
            if (existingPerson != null)
            {
                existingPerson.IntPersonId = personTest.IntPersonId;
                existingPerson.StrName = personTest.StrName;
                existingPerson.Age = personTest.Age;
                _context.PersonTest.Update(existingPerson);
                _context.SaveChanges();
            }
            return personTest;
        }
        public PersonTest GetPersonTest(long id)
        {
            var person = _context.PersonTest.Find(id);
            return person;
        }
        public List<PersonTest> GetAllPersonTests()
        {
            return _context.PersonTest.ToList();
        }

        
    }
}
