using System;

namespace D61_static_siniflar
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string isim = "Diyar";

            string soyad = "Yıldırım";

            string fullName = String.Concat(isim+"  "+ soyad);
            Console.WriteLine(fullName);


            /*
            int[] sayilar = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Array.Reverse(sayilar);
            foreach(var item in sayilar)
            {
                Console.WriteLine(item);
            }
            */


            Console.ReadLine();
        }
    }
}
