using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace FirstCrudeOperationUsingNetCore.Models
{
    public interface IPersonTestData
    {
        List<PersonTest> GetAllPersonTests();
        PersonTest GetPersonTest(long id);
        PersonTest AddPersonTest(PersonTest personTest);
        void DeletePersonTest(PersonTest personTest);
        //PersonTest EditPersonTest(PersonTest personTest);
    }
}
