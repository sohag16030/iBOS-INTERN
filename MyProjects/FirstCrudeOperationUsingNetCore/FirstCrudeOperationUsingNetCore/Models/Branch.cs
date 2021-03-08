using System;
using System.Collections.Generic;

namespace FirstCrudeOperationUsingNetCore.Models
{
    public partial class Branch
    {
        public long BranchId { get; set; }
        public string BranchName { get; set; }
        public long? PurchaseOrderCount { get; set; }
        public long? SalesOrderCount { get; set; }
    }
}
