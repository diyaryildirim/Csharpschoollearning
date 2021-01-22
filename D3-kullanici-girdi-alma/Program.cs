using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders3
{
    class Program
    {
        static void Main(string[] args)
        {
            // int a;
            // for (a = 0; a <= 10; a++)
            Console.WriteLine("Lütfen karesini almak istediğiniz sayıyı giriniz : ");

            /* Derived Versions */
            // int sayi = int.Parse(Console.ReadLine());

            /* int sayi;
            int.TryParse(Console.ReadLine(), out sayi);*/

            // double sayi = Convert.ToDouble(Console.ReadLine());
            // float sayi = float.Parse(Console.ReadLine());
            /*farklı bir versiyonu */
            // float sayi = (float)Convert.ToDouble(Console.ReadLine());
            double sayi2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Girmiş olduğunuz sayının karesi : " + (sayi2 * sayi2));

            Console.ReadLine();
        }
    }
}
