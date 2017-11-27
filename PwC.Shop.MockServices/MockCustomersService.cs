using PwC.Shop.IServices;
using PwC.Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PwC.Shop.MockServices
{
    

    public class MockCustomersService : MockItemsService<Customer>, ICustomersService
    {
        protected override ICollection<Customer> Load()
        {
            return new List<Customer>
            {
                   new Customer { Id = 1, FirstName = "Marcin", LastName = "Sulecki" },
                   new Customer { Id = 2, FirstName = "Jan", LastName = "Nowak" },
                   new Customer { Id = 3, FirstName = "John", LastName = "Smith" },
            };

        }
    }
}
