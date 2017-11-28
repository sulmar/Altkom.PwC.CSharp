using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PwC.Shop.ConsoleClient
{
    abstract class BaseCalculator : ICalculator
    {
        public delegate void Log(string message);

        Log log;

        public virtual bool CanDiscount(decimal amount)
        {
            if (log!=null)
                log("Can discount...");

            return amount > 100;
        }

        public abstract decimal Discount(decimal amount);
    }

    class HappyHoursCalculator : BaseCalculator
    {
        private decimal ratio = 0.5m;

        public override bool CanDiscount(decimal amount)
        {
            return base.CanDiscount(amount) && DateTime.Now.Hour > 9 && DateTime.Now.Hour < 16;

        }
        public override decimal Discount(decimal amount)
        {
            return amount * ratio;
        }
    }

    interface ICalculator
    {
        decimal Discount(decimal amount);

        bool CanDiscount(decimal amount);
    }

    class CyberMonday : ICalculator
    {
        public bool CanDiscount(decimal amount)
        {
            return true;
        }

        public decimal Discount(decimal amount)
        {
            return 10;
        }
    }

    class BlackFridayCalculator : ICalculator
    {
        private decimal ratio = 0.5m;

        public bool CanDiscount(decimal amount)
        {
            return true;
        }

        public decimal Discount(decimal amount)
        {
            return amount * ratio;
        }

        public void Print()
        {
            Console.WriteLine(ratio);
        }
    }

}
