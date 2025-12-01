using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMart_App_EF
{
    public class SalesRecords
    {
        public int SaleId { get; set; }
        public int CustomerId { get; set; }
        public Customers Customers { get; set; }
        public int ProductId { get; set; }
        public Products Products { get; set; }
        public string? SaleDate {  get; set; }

    }
}
