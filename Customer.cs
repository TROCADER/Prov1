using System;

namespace Prov1
{
    public class Customer
    {
        public int money;
        private Random generator = new Random();

        public Customer()
        {
            money = generator.Next(1000);
            System.Console.WriteLine("I got: " + money + " to spend");
            System.Console.WriteLine("\nWhat should I buy?");
        }
    }
}
