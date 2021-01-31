using System;

namespace D36_ornek3_fibonacciserisi
{
    class Program
    {
        static void Main(string[] args)
        {

            int bir = 0, iki = 1, uc;
            int kacinciEleman;
            Console.WriteLine("Kaçıncı elemana kadar yazdırmak istersiniz.");

            while (true)
            {
                kacinciEleman = int.Parse(Console.ReadLine());

                if (kacinciEleman > 0)
                {
                    Console.WriteLine("FIBONACCI SERISI {0}.ELEMANA KADAR YAZDIRILIYOR.", kacinciEleman);
                    if (kacinciEleman == 1)
                    {
                        Console.WriteLine(bir);
                    }
                    else
                    {
                        Console.WriteLine(bir + "\n" + iki);
                        for(int i=0; i < kacinciEleman - 2; i++)
                        {
                            uc = bir + iki;
                            bir = iki;
                            iki = uc;
                            Console.WriteLine(uc);
                        }
                        bir = 0;
                        iki = 1;
                    }
                    Console.WriteLine("FIBONACCI SERISI TAMAMLANDI.");
                    break;
                }
                else
                {
                    Console.WriteLine("Lütfen sıfırdan büyük bir değer giriniz.");
                }

            }


            Console.ReadLine();


        }
    }
}
