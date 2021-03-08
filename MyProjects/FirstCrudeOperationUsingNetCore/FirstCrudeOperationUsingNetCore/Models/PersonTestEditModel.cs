using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCrudeOperationUsingNetCore.Models
{
    public class PersonTestEditModel
    {
        public long IntPersonId { get; set; }
        public string StrName { get; set; }
        public string StrAddress { get; set; }
        public int Age { get; set; }
    }
}
