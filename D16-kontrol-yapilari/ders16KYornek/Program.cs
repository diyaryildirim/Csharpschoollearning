using System;

namespace ders16KYornek
{
    class Program
    {
        static void Main(string[] args)
        {

            // 50 üstü geçer
            // 50 altı kalır

            /*
                85 üstü AA
                70-85 arasında BA
                55-70 arasında BB
                40-55 arasında CB
                25-40 arasında CC
                25 altında FF
             */



            double not;
            Console.WriteLine("Lütfen Notunuzu giriniz");
            not = Convert.ToDouble(Console.ReadLine());


            if (not >= 85)
            {
                Console.WriteLine("Geçtiniz.");
            }
            else if(not>70 && not < 85)
            {
                Console.WriteLine("BA ile geçtiniz.");
            }
            else if (not>55 && not < 70)
            {
                Console.WriteLine("BB ile geçtiniz.");
            }
            else if(not>40 && not < 55)
            {
                Console.WriteLine("CB ile geçtiniz.");
            }
            else if(not>25 && not < 40)
            {
                Console.WriteLine("CC ile Geçtiniz.");
            }
            else
            {
                Console.WriteLine("Kaldınız");
            }

            Console.ReadLine();

        }
    }
}
