using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PwC.Shop.Models
{
    public class Order : Base
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal TotalAmount { get; set; }

        public Customer Customer { get; set; }

        public ICollection<OrderDetail> Details { get; set; }
    }
}
