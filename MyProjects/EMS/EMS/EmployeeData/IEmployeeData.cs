using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS.EmployeeData
{
    public interface IEmployeeData
    {
        List<Employee> GetEmployees { get; set; }
    }
}
