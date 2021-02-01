using System;

namespace D43_tercihe_bagli_isimlendirilmis_parametre
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim = "Diyar";
            string soyIsim = "Yıldırım";

            Console.WriteLine(FullName(isim, soyIsim));
            Console.ReadLine();
        }

        static string FullName(string isim,string soyIsim="NULL")
        {
            if(soyIsim != "NULL")
            {
                return isim +" "+ soyIsim;
            }
            else
            {
                return isim;
            }
        }
    }
}
