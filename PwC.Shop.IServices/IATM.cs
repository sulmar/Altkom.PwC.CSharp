using System;

namespace PwC.Shop.IServices
{
    public interface IATM
    {
        void Payment(decimal amount);

        decimal Widthdraw();

        decimal Saldo();
    }

    public interface IWidthdraw
    {
        decimal Execute();
    }

    public interface IPayment
    {
        void Execute(decimal amount);
    }

    public interface ISaldo
    {
        decimal Get();
    }

    public class MyATM : IPayment, ISaldo
    {


        public decimal Get()
        {
            throw new NotImplementedException();
        }

        void IPayment.Execute(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
