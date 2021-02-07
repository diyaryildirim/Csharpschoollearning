using System;

namespace D48_ornek1_selamlama
{
    class Program
    {

        class Insan
        {
            string isim;
            int yas;
            public void selamVer()
            {
                Console.WriteLine("Merhaba");
            }
            public void bilgileriSor()
            {
                Console.WriteLine("Adın ne ve yaşın kaç?");
            }
            public void cevapver()
            {
                Console.WriteLine("Benim adım " + isim + "ve yaşım" + yas);
            }
            public void isimVeYasDuzenle(string isim, int yas)
            {
                this.isim = isim;
                this.yas = yas;
            }
        }
        static void Main(string[] args)
        {
            Insan i1 = new Insan();
            Insan i2 = new Insan();

            i1.isimVeYasDuzenle("Mehmet", 39);
            i2.isimVeYasDuzenle("Diyar", 65);

            i1.selamVer();
            i2.selamVer();
            i1.bilgileriSor();
            i2.cevapver();
            i2.bilgileriSor();
            i1.cevapver();


            Console.ReadLine();
        }
    }
}
