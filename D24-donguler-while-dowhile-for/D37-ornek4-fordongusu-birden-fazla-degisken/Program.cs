using System;

namespace D37_ornek4_fordongusu_birden_fazla_degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            //Çarpım Tablosu

            for (int i = 1, j = 1; i <= 10;)
            {
                Console.WriteLine(i+ " * " +j+ " = "+i * j);
                j++;
                if (j > 10)
                {
                    i++;
                    j = 1;
                }
            }

            Console.ReadLine();

        }
    }
}
