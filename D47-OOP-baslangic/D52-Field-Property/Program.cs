using System;

namespace D52_Field_Property
{
    class Program
    {
        class Human
        {
            string isim; //field -> Alan
            int yas;

            public string Isim //Property -> mülk
            {
                get { return Isim; } //Get -> almak
                set { Isim = value; } //Set -> kurmak  value -> Değer
            }
            public int Yas //Property -> mülk 
            {
                get { return yas; }
                set { if(value >= 0)yas = value; }
            }

            //Auto-Implemented Property
            public Human(string Cinsiyet)
            {
                this.Cinsiyet = cinsiyet;
            }
            public string Cinsiyet { get; private set; }
            public int Hesap { get; set; }
        }
        static void Main(string[] args)
        {
            Human i1 = new Human("Erkek");
            i1.Isim = "Diyar Yıldırım";
            i1.Yas = 21;
            i1.Hesap = 15000;
            Console.WriteLine(i1.Isim + " " + i1.Yas + "  " +i1.Cinsiyet + "   "+i1.Hesap);



            Console.ReadLine();
        }
    }
}
