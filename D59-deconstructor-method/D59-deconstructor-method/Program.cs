using System;

namespace D59_deconstructor_method
{
    class Program
    {
        //Constructor -> Yapıcı Metot
        //Deconstructor -> Yıkıcı metot

        class Insan
        {
            public Insan()
            {
                Console.WriteLine("Insan Oluşturuldu.");
            }
            ~Insan()
            {
                Console.WriteLine("Obje yok oldu.");
            }
        }
        

        static void ObjeleriOluştur()
        {
            Insan i1 = new Insan();
            Insan i2 = new Insan();
        }
        static void Main(string[] args)
        {
            ObjeleriOluştur();
            GC.Collect();

            Console.ReadLine();
        }
    }
}
