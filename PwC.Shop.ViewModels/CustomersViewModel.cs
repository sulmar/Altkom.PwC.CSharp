using PwC.Shop.IServices;
using PwC.Shop.MockServices;
using PwC.Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PwC.Shop.ViewModels
{
    public class CustomersViewModel : BaseViewModel
    {
        public ICollection<Customer> Customers { get; set; }

        private readonly ICustomersService customersService;

        public CustomersViewModel()
            : this(new MockCustomersService())
        {
        }

        public CustomersViewModel(ICustomersService customersService)
        {
            this.customersService = customersService;

            Load();
        }
        

        private void Load()
        {
            Customers = customersService.Get();
        }

    }
}
