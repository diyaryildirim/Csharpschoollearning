using System;

namespace D58_string_ozellikleri_metotları
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim = "Diyar Yıldırım";

            isim = isim.Substring(isim.IndexOf('Y'));

           //isim = isim.Remove(isim.IndexOf(" "), 1) ;

            //isim = isim.Insert(0, "Hacker");

            //isim = isim.Replace("Black Hat", "Hacker");

            /*if (isim.Contains("Diyar"))
            {
                isim = isim.Replace("Diyar", "Hacker");
            }*/

            Console.WriteLine(isim);



            //Index of -> bir ifadenin indeksini bulma 
            //Insert ->eklemek
            //Replace -> yer değiştirme
            //contains -> bir ifadenin o strinte bulunup bulunmadğı "Bool"

            /*
             for(int i=0;i<İsim.Length; i++)
            {
                Console.WriteLine(İsim[i]);
                    
            }
             */


            Console.ReadLine();
        }
    }
}
