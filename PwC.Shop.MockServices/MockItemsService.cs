using PwC.Shop.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PwC.Shop.MockServices
{

    public abstract class MockItemsService<TItem> : IItemsService<TItem>
        where TItem : class
    {
        private ICollection<TItem> items;

        protected abstract ICollection<TItem> Load();

        public MockItemsService()
        {
            items = Load();
        }

        public void Add(TItem item)
        {
            items.Add(item);
        }

        public ICollection<TItem> Get()
        {
            return items;
        }

        public TItem Get(int id)
        {
            throw new NotSupportedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(TItem item)
        {
            throw new NotImplementedException();
        }
    }
}
