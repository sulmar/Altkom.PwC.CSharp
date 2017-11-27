using PwC.Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PwC.Shop.IServices
{
    public interface IOrdersService : IItemsService<Order>
    {
        ICollection<Order> Get(DateTime from, DateTime to);
    }
}
