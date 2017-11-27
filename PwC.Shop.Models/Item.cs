namespace PwC.Shop.Models
{
    public abstract class Item : Base
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

}
