using PwC.Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PwC.Shop.IServices
{

    public interface ICustomersService
    {
        ICollection<Customer> Get();

        Customer Get(int id);

        void Add(Customer customer);

        void Update(Customer customer);

        void Remove(int id);

    }

}
