using System;

namespace daireninalanvecevresi
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14;
            double daireninYaricapi;

            Console.WriteLine("Lütfen Dairenin yarıçapını giriniz.");
            daireninYaricapi = Convert.ToDouble(Console.ReadLine());


            double daireninCevresi = 2 * PI * daireninYaricapi;
            double daireninAlani = PI * daireninYaricapi * daireninYaricapi;


            Console.WriteLine("Dairenin Çevresi = " + daireninCevresi);
            Console.WriteLine("Dairenin Alanı = " + daireninAlani);


            Console.ReadLine();

        }
    }
}
