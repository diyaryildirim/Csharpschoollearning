using System;

namespace D56_jaggead_arrays
{
    class Program
    {
        //Jaggead Arrays -> Pürüzlü Diziler
        static void Main(string[] args)
        {
            //int[,] sayilar = { { 2, 3 }, { 5 } };

            int[][] sayilar = { new int[] { 2, 4 } ,new int[] { 4 } };

            Console.WriteLine(sayilar[0][0]);

            Console.ReadLine();
        }
    }
}
