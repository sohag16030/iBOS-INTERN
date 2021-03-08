using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace FirstCrudeOperationUsingNetCore.Models
{
    public class OrderService : IOrderData
    {
        private readonly RNDContext _context;

        public OrderService(RNDContext context)
        {
            _context = context;
        }

        public string InvoiceNoGenerator(string branchName)
        {
            string invoice = "";
            Branch PastRecord = _context.Branch.SingleOrDefault(x => x.BranchName == branchName);
            var purOrdercnt = PastRecord.PurchaseOrderCount ;

            purOrdercnt = purOrdercnt.HasValue ? purOrdercnt += 1 : purOrdercnt = 1;
            PastRecord.PurchaseOrderCount = purOrdercnt;
            _context.Branch.Update(PastRecord);
            _context.SaveChanges();

            var PastPurchaseOrderCount = PastRecord.PurchaseOrderCount;


            DateTime date = DateTime.Now.Date;
            var year = date.Year;
            string Y = year.ToString();
            Y = Y.Remove(0, 2);
            var month = date.Month;
            invoice =month.ToString() + Y + PastPurchaseOrderCount.ToString();

            return invoice;
            
        }
    }
}
