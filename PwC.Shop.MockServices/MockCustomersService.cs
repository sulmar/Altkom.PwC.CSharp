using PwC.Shop.IServices;
using PwC.Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PwC.Shop.MockServices
{
    public class MockCustomersService : ICustomersService
    {
        private ICollection<Customer> customers = new List<Customer>
        {
               new Customer { Id = 1, FirstName = "Marcin", LastName = "Sulecki" },
               new Customer { Id = 2, FirstName = "Jan", LastName = "Nowak" },
               new Customer { Id = 3, FirstName = "John", LastName = "Smith" },
        };


        public void Add(Customer customer)
        {
            #if DEBUG
                Console.WriteLine("XXXX");
#endif

            customers.Add(customer);

        }

        public ICollection<Customer> Get()
        {
            return customers;
        }

        public Customer Get(int id)
        {
            throw new NotSupportedException();

        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
