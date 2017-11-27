using PwC.Shop.Models;
using System.Collections.Generic;

namespace PwC.Shop.MockServices
{
    public class MockProductsService : MockItemsService<Product>
    {
        protected override ICollection<Product> Load()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Product 1"},
                new Product { Id = 2, Name = "Product 2"},
                new Product { Id = 3, Name = "Product 3"},
            };
        }

        public new ICollection<Product> Get()
        {
            return null;
        }
    }
}
