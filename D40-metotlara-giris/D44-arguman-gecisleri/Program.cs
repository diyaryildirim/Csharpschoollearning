using System;

namespace D44_arguman_gecisleri
{
    class Program
    {
        //Passing by value   değer geçişi
        //Passing by reference adres ref
        //adres out 
        static void Main(string[] args)
        {
            int x = 3;
            kupHesapla(x);
            Console.WriteLine(x);
            Console.ReadLine();
        }
        static void kupHesapla(int sayi)
        {
            sayi = 5;
            sayi = sayi * sayi * sayi;
            Console.WriteLine(sayi);
        }
    }
}
