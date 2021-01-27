using System;

namespace D33_for_dongusu
{
    class Program
    {
        static void Main(string[] args)
        {
             int sayi = 1;

            Console.WriteLine("************WHİLE DÖNGÜSÜ***********");

               while (sayi <= 10)
               {
                  Console.WriteLine(sayi);
                  sayi++;
               }

            Console.WriteLine("************WHİLE DÖNGÜSÜ***********");
                
              for (int i = 1; i <= 10; i++)
              {
                  Console.WriteLine(i);
              }

               Console.ReadLine();
           
        }
    }
}
