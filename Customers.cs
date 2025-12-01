using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMart_App_EF
{
    public class Customers
    {
        public int CustomerId { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }
        public ICollection<SalesRecords>? SalesRecord { get; set; }

    }
}
