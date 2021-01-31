using System;

namespace D35_ornek2_yildizlardan_sekil_yapma
{
    class Program
    {
        static void Main(string[] args)
        {
            int bosluk, yildiz, satir;
            Console.WriteLine("Kaç satır baklaa dilimim yazdırmak istiyorsunuz.");
            satir = Convert.ToInt32(Console.ReadLine());
            bosluk = satir / 2;
            yildiz = 1;
            for(int i= 0; i<satir; i++)
            {
                for(int j=0; j<bosluk; j++)
                {
                    Console.Write(" ");
                }
                for(int z=0; z< yildiz; z++)
                {
                    Console.Write("*");
                }

                if (i < satir / 2)
                {
                    bosluk--;
                    yildiz += 2;
                }
                else
                {
                    bosluk++;
                    yildiz -= 2;
                }

                Console.WriteLine();
            }




            Console.ReadLine();

        }
    }
}
