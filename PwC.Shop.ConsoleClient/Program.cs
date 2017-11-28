using PwC.Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PwC.Shop.ConsoleClient.Extensions;

namespace PwC.Shop.ConsoleClient
{
    class Program
    {
        

        static IEnumerable<Person> GetPersons()
        {
            var persons = new List<Person>
            {
                new Person { FirstName = "Marcin", City = "Bydgoszcz", Age = 18 },
                new Person { FirstName = "Radek", City = "Katowice", Age = 28 },
                new Person { FirstName = "Tomek", City = "Katowice", Age = 25 },
                new Person { FirstName = "Grzegorz", City = "Katowice", Age = 28 },
                new Person { FirstName = "Kamil", City = "Katowice", Age = 19 },
            };

            return persons;
        }

        // Leniwe kolekcje
        static IEnumerable<Person> GetLazyPersons()
        {
            yield return new Person { FirstName = "Marcin", City = "Bydgoszcz", Age = 18 };
            yield return new Person { FirstName = "Radek", City = "Katowice", Age = 28 };
            yield return new Person { FirstName = "Tomek", City = "Katowice", Age = 25 };
            yield return new Person { FirstName = "Grzegorz", City = "Katowice", Age = 28 };
            yield return new Person { FirstName = "Kamil", City = "Katowice", Age = 19 };
        }

        //  public delegate void MyDelegate();

        static object sync;

        static void Main(string[] args)
        {
            Person person1 = null;

            lock (sync)
            {
                if (person1 == null)
                {
                    person1 = new Person();
                }
            }

            //lock(lockObject)
            //{

            //}

            Lazy<Person> person = new Lazy<Person>();

            Console.WriteLine(person.Value.FirstName);

            person.Value.FirstName = "Marcin";

            if (person.IsValueCreated)
            {
                Console.WriteLine(person.Value.FirstName);
            }
            



            //var persons = GetPersons();

            //foreach (var person in persons)
            //{
            //    Console.WriteLine(person.FirstName);
            //}



            // przychodzi lista stringow i wyswietl wszystkie elementy

            LinqTest();



            //var members = names
            //    .Where(item => item.ToLower().Contains("k"))
            //    .OrderBy(item => item);


            //var trainers = names.Where(item => item.Contains("Marcin"));

            //var team = members.Union(trainers);

            //var q = names.Except(trainers);


            //var results = new List<string>();

            //foreach (var item in texts)
            //{
            //    if (item.ToLower().Contains("k"))
            //    {
            //        results.Add(item);
            //    }
            //}


          //  Display2(members);

            //   Display(texts);

            //   Display2(texts);


            // DelegateTest();

            #region 
            // var isHoliday = DateTimeHelper.IsHoliday(DateTime.Today);

            // ExtensionMethodTest();

            // CalculatorTest();

            // PolimorfizmTest();

            // var result = TupleTest();

            Console.ReadKey();

            #endregion
        }

        private static void LinqTest()
        {
            var customers = new List<Person>
            {
                new Person { FirstName = "Marcin", City = "Bydgoszcz", Age = 18 },
                new Person { FirstName = "Radek", City = "Katowice", Age = 28 },
                new Person { FirstName = "Tomek", City = "Katowice", Age = 25 },
                new Person { FirstName = "Grzegorz", City = "Katowice", Age = 28 },
                new Person { FirstName = "Kamil", City = "Katowice", Age = 19 },
            };

            var results1 = customers
                            .Where(customer => customer.City == "Katowice")
                            .Select(customer => customer);

            // Query expression
            var results = from customer in customers
                          where customer.City == "Katowice"
                          select customer;
        }

        private static void Display2(IEnumerable<string> texts)
            => texts.ToList().ForEach(item => Console.WriteLine(item));

        private static void Display(List<string> texts)
        {
            foreach (var item in texts)
            {
                Console.WriteLine(item);
            }
        }

        private static void DelegateTest()
        {
            Action del = null;

            del += delegate
            {
                Console.WriteLine();
            };

            del += () => Console.WriteLine();




            // HappyHoursCalculator happyHoursCalculator = new HappyHoursCalculator();
            // happyHoursCalculator.Log += Console.WriteLine;

            //SendSms("Hello World!");
            //SendEmail("Hello World!");

            Action<string> send;
            send = SendSms;
            send += SendEmail;
            send += Console.WriteLine;
            send += delegate (string tekst)
            {
                Console.WriteLine($"{tekst} anonimowa metoda");
            };

            send += tekst => Console.WriteLine($"{tekst} lambda");

            var methods = send.GetInvocationList().ToList();

            if (send != null)
            {
                send?.Invoke("Hello Delegate!");
            }

            send -= SendSms;

            send = null;

            send?.Invoke("Hello 2!");
        }

        // public delegate void Send(string message);



        public delegate bool CanSend(string message);

        // Func<string, bool> == Predicate<string>
        

        private static void SendSms(string message)
        {
            Console.WriteLine($"sending {message} via sms");
        }

        private static void SendEmail(string message) => Console.WriteLine($"sending {message} via email");

        private static void ExtensionMethodTest()
        {
            var isHoliday = DateTime.Today.IsHoliday();

            DateTime.Today.AddWorkingDays(10);
        }


        /// Install-Package System.ValueTuple
        private static (int age, string name) TupleTest()
        {
            var result = (99, "Marcin");

            return result;
        }


        private static void CalculatorTest()
        {
            ICalculator calculator = new BlackFridayCalculator();

            decimal result = calculator.Discount(200);
        }

      
        private static void PolimorfizmTest()
        {
            Item item = new Product
            {
                Id = 1,
                Name = "Produkt 1",
                Price = 10,
                Color = "Red"
            };


            item.Print();
        }
    }
}
