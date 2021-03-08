using System;
using System.Collections.Generic;

namespace FirstCrudeOperationUsingNetCore.Models
{
    public partial class SalesMan
    {
        public long IntSalesmanId { get; set; }
        public byte[] StrName { get; set; }
        public DateTime DateTime { get; set; }
    }
}
