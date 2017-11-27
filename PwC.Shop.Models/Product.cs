using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PwC.Shop.Models
{
    public class Product : Item
    {
        public string Color { get; set; }


        public new void Print()
        {
            System.Console.WriteLine($"{Id} {Name} {Price} {Color}");
        }
    }

}
