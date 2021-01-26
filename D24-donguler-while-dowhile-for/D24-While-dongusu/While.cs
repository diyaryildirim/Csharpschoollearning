using System;

namespace D24_While_dongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int i = 0;

            
            while (i <= 10) // while Turkcesi -iken
            {
                Console.WriteLine(i);
                i+=2;
            }
            */

            string isim = "Kaan";

            int sayac = 0;

            while (isim=="Kaan")
            {
                Console.WriteLine(isim);
                sayac++;
                if (sayac ==10)
                {
                    isim = "Mehmet";
                }
            }





            Console.ReadLine();

        }
    }
}
