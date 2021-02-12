using System;
using System.Linq;

namespace D57_dizilerin_ozellikleri
{
    class Program
    {
        static void Main(string[] args)
        { 
         
            int[] sayilar = { 2, 3, 4,12, 5, 6, };

            //int[,,,,,,] sayilar2= new int[2,3,3,3,3,3];

            //int[,,,,,] sayilar2 = new int[2, 2, 2, 3, 3, 3];

            Console.WriteLine(sayilar.Rank);

            Console.WriteLine(sayilar.Max());
            Console.ReadLine();
        }
    }
}
