using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders4inputoutputornek
{
    class Program
    {
        static void Main(string[] args)
        {
            // program that takes the user's name, age and height and prints it on the screen
            // kullanıcıdan ismini yaşını ve boyunu (metre cinsinden) alıp ekrana yazdıran Program
            
            string isim;
            int yas;
            float boy;

            Console.WriteLine("Lütfen İsminizi Giriniz :");
            isim = Console.ReadLine();
            Console.WriteLine("Lütfen Yaşınızı Giriniz :");
            yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen Boyunuzu Metre cinsinden Giriniz : ");
            boy = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" İsminiz: " + isim + " Yaşınız: " + yas + " Boyunuz: "+ boy + " metre ");

            Console.ReadLine();

        }
    }
}
