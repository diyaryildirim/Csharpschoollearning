using System;

namespace D62_this_readonly_const
{
    class Program
    {
        //this readonly
        class Isci
        {
            public readonly double maas;
            public Isci(double maas)
            {
                this.maas = maas;
            }
        }

        //1. Readonly constructor içerisinden değişebilir.
        //2. Readonly sabit değeri sonradan değer atanabilir
                //const sabitinin değeri oluşturulduğu anda verilmek zorundadır.
        //3. Readonly matematiksel işlemlerin sonucunda değerine kavuşabilir.
                //const matematiksel işlemlerin sonucunda değerine kavuşmaz.
        static void Main(string[] args)
        {

            Isci i1 = new Isci(5500.50);
            Isci i2 = new Isci(2200.6);

            Console.WriteLine(i1.maas + " " + i2.maas);

           Console.ReadLine();
        }
    }
}
