using System;

namespace D51_Constructor_method
{
    class Program
    {
        class Insan
        {
            string isim;
            int yas = 21;

            public Insan()
            {
                Console.WriteLine("Yeni bir obje yaratıldı");
            }
            public Insan(string isim)
            {
                this.isim = isim;
            }
            public void bilgileriSoyle()
            {
                Console.WriteLine("Adım {0} Yaşım {1}", isim, yas);
            }
        }
        static void Main(string[] args)
        {
            Insan i1 = new Insan();
            Insan i2 = new Insan("Diyar Yıldırım");
            i2.bilgileriSoyle();



            Console.ReadLine();
        }
    }
}
