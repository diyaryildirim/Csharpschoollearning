using System;

namespace D46_recursive_metotlar
{
    class Program
    {
        //Recursive Önyinelemeli -> KENDİ KENDİNİ ÇAĞIRAN METOTLAR
        //Iterative Tekrarlamalı metot 

        static void Main(string[] args)
        {
            Console.WriteLine(Recursivefaktoriyel(5));
            Console.WriteLine(iterativeFaktoriyel(6));
            Console.ReadLine();
            
        }
        static int Recursivefaktoriyel(int sayi)
        {
            if (sayi == 1)
            {
                return 1;
            }
            return sayi * Recursivefaktoriyel(sayi - 1);
        }
        static int iterativeFaktoriyel(int sayi)
        {
            int sonuc = 1;
            while (sayi > 0)
            {
                sonuc *= sayi;
                sayi--;
            }
            return sonuc;
        }
    }
}
