using System;

namespace daireninalanvecevresi
{
    class Program
    {
        static void Main(string[] args)
        {
            //f(x)=ax^2+bx+c 4x^2+2x+3
            //delta=b^2-4ac
            //f(2) f(4)

            double a, b, c, x, sonuc, delta;
            Console.WriteLine("Lütfen fonksiyonun a b c ve x değerlerini sırasıyla giriniz.");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            x = Convert.ToDouble(Console.ReadLine());

            sonuc = a * x * x + b * x + c;
            delta = b * b - 4 * a * c;

            Console.WriteLine("f({0}) = " + sonuc + "Delta = " + delta, x);

            Console.ReadLine();
                
        }
    }
}
