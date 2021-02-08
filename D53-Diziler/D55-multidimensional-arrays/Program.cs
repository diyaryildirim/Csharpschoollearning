using System;

namespace D55_multidimensional_arrays
{
    class Program
    {
        //Multidimensional Arrays
        static void Main(string[] args)
        {
            int[ , , ] sayilar = { { {2,3 },{ 4,5 } } ,{ {4,5},{6,7} },{ {6,7},{8,9} } };

           

            for(int x=0; x<3 ; x++)
            {
                for(int y=0; y<2 ;y++)
                {
                    for(int z=0; z<2; z++)
                    {
                        Console.Write(sayilar[x, y, z]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
