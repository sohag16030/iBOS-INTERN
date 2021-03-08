using FirstCrudeOperationUsingNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace FirstCrudeOperationUsingNetCore.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderData _OrderData;
        public OrderController(IOrderData OrderData)
        {
            _OrderData = OrderData;
        }
        public IActionResult Index()
        {
            return View();   
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult AddOrderRecord()
        {
            return Ok();
        }

        [HttpPost]
        [Route("api/[controller]")]
        public string GenerateInvoiceCode(string branchName)
        {
            string invoiceCode = _OrderData.InvoiceNoGenerator(branchName);
            return invoiceCode;
        }
    }
}
