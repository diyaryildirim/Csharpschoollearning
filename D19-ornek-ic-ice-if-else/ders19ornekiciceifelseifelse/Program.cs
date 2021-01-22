using System;

namespace ders19ornekiciceifelseifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             0-3 bebek
            3-7 bebekten sonraki
            7-14 cocukluk
            14-18 ergenlik
                                        18-25 genclik
                                        25-40 orta yas
                                        40-55 orta yas ustu
                                        55-  yaşlılık
             */
            int yas;

            Console.WriteLine("Lütfen yaşınızı giriniz.");
            yas = int.Parse(Console.ReadLine());

            if (yas >= 18)
            {
                if (yas > 55)
                {
                    Console.WriteLine("Yaşlısın"),
                }
                else if (yas > 40)
                {
                    Console.WriteLine("Orta yaş üstündesin.");
                }
                else if (yas > 25)
                {
                    Console.WriteLine("Genç yaştasın.");
                }
                else
                {
                    Console.WriteLine("Ergensin.");
                }
            }
            else
            {
                if (yas < 3)
                {

                }
                else if (yas < 7)
                {

                }
                else if (yas < 14)
                {
                    Console.WriteLine("Çocuk yaştasın.");
                }
                else
                {

                }
            }


        }
    }
}
