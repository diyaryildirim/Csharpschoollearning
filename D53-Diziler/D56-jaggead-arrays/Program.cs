using System;

namespace D56_jaggead_arrays
{
    class Program
    {
        //Jaggead Arrays -> Pürüzlü Diziler
        static void Main(string[] args)
        {
            //int[,] sayilar = { { 2, 3 }, { 5 } };

            int[][] sayilar = new int[2][] { new int[] { 2, 3 }, new int[] { 4 } };
            // int[][] sayilar = { new int[] { 2, 4 }, new int[] { 4 } };

            //Console.WriteLine(sayilar[1][0]);

            int[][,] sayilar2 = new int[3][,] { new int[,] { { 2, 3 }, { 3, 4 } } , new int[,] { { 4 }, { 5 } }, new int[,] { { 1, 2, 3 }, { 4, 5, 6 } }};

            Console.WriteLine(sayilar2[2][0, 2]);

            Console.ReadLine();
        }
    }
}
