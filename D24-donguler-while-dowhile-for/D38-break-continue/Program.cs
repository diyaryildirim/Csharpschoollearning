using System;

namespace D38_break_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            // break     kırmak
            // continue  devam
            int i = 1;
            while (i <= 100)
            {
                if (i % 7 == 0)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                i++;
            }

            Console.ReadLine();

        }
    }
}
