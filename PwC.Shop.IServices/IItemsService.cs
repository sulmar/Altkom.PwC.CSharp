using System.Collections.Generic;

namespace PwC.Shop.IServices
{

    // interfejs generyczny
    public interface IItemsService<TItem>
        where TItem : class
    {
        ICollection<TItem> Get();
        TItem Get(int id);
        void Add(TItem item);
        void Update(TItem item);
        void Remove(int id);
    }
}
