using System;

namespace D47_OOP_baslangic
{
    class Program
    {
        //Taslak Instance - ornek      Instantiation - ornekleme
        class Insan
        {
            private string isim;
            private int yas;
            public void yurume()
            {
                Console.WriteLine("Yürüyorr...");
            }
            public void isimVeYasDuzenle(string isim, int yas)
            {
                this.isim = isim;
                this.yas = yas;
            }
            public string isimVeYasiSoyle()
            {
                return isim + " " + yas;

            }
        }
        static void Main(string[] args)
        {

            Insan i1 = new Insan();
            
            i1.isimVeYasDuzenle("Diyar Yıldırım", 21);
            Console.WriteLine(i1.isimVeYasiSoyle());
            i1.yurume();

            Console.ReadLine();
        }
    }
}
