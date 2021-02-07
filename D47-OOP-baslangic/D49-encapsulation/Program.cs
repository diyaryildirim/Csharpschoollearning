using System;

namespace D49_encapsulation //Kapsülleme Bilgileri Gizleme
{
    class Program
    {
        class Futboller
        {
            public int bonservisBedeli;
            public int getbonservisBedeli()
            {
                return bonservisBedeli;
            }
            public void setbonservisBedeli(int fiyat)
            {
                this.bonservisBedeli = fiyat;
            }
        }


        static void Main(string[] args)
        {
            Futboller f1 = new Futboller();
            f1.setbonservisBedeli(1500000);

            Console.WriteLine(f1.getbonservisBedeli());

            Console.ReadLine();
        }
    }
}
