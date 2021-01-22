using System;

namespace ders15KontrolYapilari
{
    class Program
    {
        static void Main(string[] args)
        {

            int yas = 25;

            if (yas < 18)
            {
                Console.WriteLine("Yaşı 18 den küçük");
            }
            else if (yas>18 && yas < 25)
            {
                Console.WriteLine("Yaşı 18 ile 25 arasındadır");
            }
            else (yas = 25)
            {
                Console.WriteLine("Yaşı 25'dir");
            }
        }
    }
}
