using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace FirstCrudeOperationUsingNetCore.Models
{
    public interface IOrderData
    {
        string InvoiceNoGenerator(string branchName);
    }
}
