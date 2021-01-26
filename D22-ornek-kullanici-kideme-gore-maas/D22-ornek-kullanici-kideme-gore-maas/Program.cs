using System;

namespace D22_ornek_kullanici_kideme_gore_maas
{
    class Program
    {
        static void Main(string[] args)
        {
            string meslek;
            Console.WriteLine("Lütfen Mesleğinizi Giriniz.");
            meslek = Console.ReadLine();


            switch (meslek)
            {
                case "Teacher":
                    Console.WriteLine("3500-5000 arası maaş");
                    break;
                case "Doctor":
                    Console.WriteLine("5000-10000 arası maaş");
                    break;
                case "Engineer":
                    Console.WriteLine("7500-20000 arası maaş");
                    break;
                case "Car driver":
                    Console.WriteLine("3700-6500 arası maaş");
                    break;
                case "Nurse":
                    Console.WriteLine("7000-10000 arası maaş");
                    break;
                case "Goalkeeper":
                    Console.WriteLine("35000000-50000000 arası maaş");
                    break;
                default:
                    Console.WriteLine("Mesleğinizin Maaşı bilimemektedir.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
