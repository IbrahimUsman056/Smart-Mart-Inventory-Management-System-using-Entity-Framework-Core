using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMart_App_EF
{
    public class Products
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? Category { get; set; }
        public ICollection<SalesRecords>? SalesRecord { get; set; }

    }
}
