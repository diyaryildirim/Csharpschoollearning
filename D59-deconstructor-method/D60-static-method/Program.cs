using System;

namespace D60_static_method
{
    class Program
    {
        class Insan
        {
            private static int insanSayisi = 0;
            public const double PI = 3.14;
            public int yas;
            public Insan()
            {
                insanSayisi++;
            }
            public static int InsanSayisiniSoyle()
            {
                return insanSayisi;
            }
        }

        class Koordinat
        {
            public static int X;
            public static int Y;

            public Koordinat()
            {
                X = 10;
                Y = 15;
            }
        }

        static void Main(string[] args)
        {
            Insan i1 = new Insan();
            Insan i2 = new Insan();
            Insan i3 = new Insan();
            Insan i4 = new Insan();
            Insan i5 = new Insan();
            Insan i6 = new Insan();


            i1.yas = 25;
            i2.yas = 30;
            i3.yas = 21;
            i4.yas = 24;
            i5.yas = 27;
            i6.yas = 31;

            Koordinat p1 = new Koordinat();

            Console.WriteLine(Koordinat.X+ "  " +Koordinat.Y);

            Console.WriteLine(Insan.InsanSayisiniSoyle()+ "  " +Insan.PI);
            Console.ReadLine();
        }

    }
}
