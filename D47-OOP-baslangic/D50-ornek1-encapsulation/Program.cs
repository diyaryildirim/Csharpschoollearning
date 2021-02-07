using System;

namespace D50_ornek1_encapsulation
{
    class Program
    {
        class Bankaccount
        {
            private int balance;

            public void cashdeposit(int quantity)
            {
                balance += quantity;
            }
            public void cashdraft(int quantity)
            {
                balance -= quantity;
            }
            public int balanceinquiry()
            {
                return balance;
            }
        }

        static void Main(string[] args)
        {
            Bankaccount b1 = new Bankaccount();
            Console.WriteLine(b1.balanceinquiry());

            b1.cashdeposit(1500000);
            Console.WriteLine(b1.balanceinquiry());
            b1.cashdraft(750000);
            Console.WriteLine(b1.balanceinquiry());


            Console.ReadLine();
        }
    }
}
