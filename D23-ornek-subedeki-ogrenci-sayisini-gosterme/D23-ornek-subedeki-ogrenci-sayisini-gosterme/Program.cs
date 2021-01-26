using System;

namespace D23_ornek_subedeki_ogrenci_sayisini_gosterme
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D;
            char sube;

            Console.WriteLine("lütfen A şubesinin sınıf mevcudunu giriniz");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("lütfen B şubesinin sınıf mevcudunu giriniz");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("lütfen C şubesinin sınıf mevcudunu giriniz");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("lütfen D şubesinin sınıf mevcudunu giriniz");
            D = int.Parse(Console.ReadLine());

            Console.WriteLine("hangi sınıftaki sınıf mevcudunu merak ediyorsunuz A/B/C/D  ?");
            sube = Convert.ToChar(Console.ReadLine());
            switch (sube)
            {
                case 'A':
                    Console.WriteLine(A);
                    break;
                case 'B':
                    Console.WriteLine(B);
                    break;
                case 'C':
                    Console.WriteLine(C);
                    break;
                case 'D':
                    Console.WriteLine(D);
                    break;
                default:
                    Console.WriteLine("Girmiş olduğunuz şube bulunmamaktadır. (A/B/C/D)");
                    break;
            }

            Console.ReadLine();




        }

    }
}
