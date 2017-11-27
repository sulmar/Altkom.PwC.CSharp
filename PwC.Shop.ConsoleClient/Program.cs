using PwC.Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PwC.Shop.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Item item = new Product
            {
                Id = 1,
                Name = "Produkt 1",
                Price = 10,
                Color = "Red"
            };


            item.Print();

            Console.ReadKey();

        }
    }
}
