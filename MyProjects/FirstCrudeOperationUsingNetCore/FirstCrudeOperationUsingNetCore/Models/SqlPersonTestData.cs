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
            throw new NotImplementedException();
            ///return  _context.PersonTest.Add(personTest);
        }

        public void DeletePersonTest(PersonTest personTest)
        {
            throw new NotImplementedException();
        }

        public PersonTest EditPersonTest(PersonTest personTest)
        {
            throw new NotImplementedException();
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
