using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PwC.Shop.Models
{
    public class OrderDetail : Base
    {
        public int Id { get; set; }

        public Item Item { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal Amount
        {
            get
            {
                return Quantity * UnitPrice;
            }
        }
    }
}
