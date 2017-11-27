using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PwC.Shop.Models
{
    public class Customer : Base
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                // return FirstName + " " + LastName;

                // return string.Format("{0} {4}", FirstName, LastName);

                // C# 6.0
                return $"{FirstName} {LastName}";
            

            }
        }

    }
}
