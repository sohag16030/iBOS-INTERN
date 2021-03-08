using System;
using System.Collections.Generic;

namespace FirstCrudeOperationUsingNetCore.Models
{
    public partial class SalesOrder
    {
        public long OrderId { get; set; }
        public string InvoiceNo { get; set; }
        public long Count { get; set; }
    }
}
