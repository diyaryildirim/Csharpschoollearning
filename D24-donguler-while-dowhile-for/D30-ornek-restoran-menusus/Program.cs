using System;

namespace D30_ornek_restoran_menusus
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1 Adana 12.50 TL
            // 2 Beyti 22.75 TL
            // 3 Salata 7.50 TL
            // 4 Çorba 10.00 TL
            // 5 içecek 5.00 TL
            // 6 Çıkış

            int secim;
            double toplam = 0;


            do
            {
                Console.WriteLine("1 Adana 12.50 Tl");
                Console.WriteLine("2 Beyti 22.75 Tl");
                Console.WriteLine("3 Salata 7.50 Tl");
                Console.WriteLine("4 Çorba 10.35 Tl");
                Console.WriteLine("5 İçecek 5.00 Tl");
                Console.WriteLine("6 Çıkış ");
                Console.WriteLine("Lütfen seçim yapınız.");
                secim = int.Parse(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        toplam += 12.50;
                        Console.WriteLine("Şu anki hesap = " + toplam);
                        break;

                    case 2:
                        toplam += 22.75;
                        Console.WriteLine("Şu anki hesap = " + toplam);
                        break;

                    case 3:
                        toplam += 7.50;
                        Console.WriteLine("Şu anki hesap = " + toplam);
                        break;

                    case 4:
                        toplam += 10.35;
                        Console.WriteLine("Şu anki hesap = " + toplam);
                        break;

                    case 5:
                        toplam += 5.85;
                        Console.WriteLine("Şu anki hesap = " + toplam);
                        break;

                    case 6:
                        Console.WriteLine("hesabınız tamalandı.");
                        break;

                    default:
                        Console.WriteLine("Lütfen 1-6 arasında bir seçim yapınız");
                        break;
                }
            
                
            } while (secim != 6);

            


            Console.WriteLine("Toplam Hesap = " + toplam);
            Console.ReadLine();

           
        }
    }
}
