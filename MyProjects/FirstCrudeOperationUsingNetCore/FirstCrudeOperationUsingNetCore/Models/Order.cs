using System;
using System.Collections.Generic;

namespace FirstCrudeOperationUsingNetCore.Models
{
    public partial class Order
    {
        public long OrderId { get; set; }
        public string InvoiceNo { get; set; }
    }
}
