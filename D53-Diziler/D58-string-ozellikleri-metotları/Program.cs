using System;

namespace D58_string_ozellikleri_metotları
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim = "Diyar Yıldırım";

            isim = isim.Insert(0, "Hacker");

            Console.WriteLine(isim);

            //Index of

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
