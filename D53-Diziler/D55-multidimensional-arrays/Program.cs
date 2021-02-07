using System;

namespace D55_multidimensional_arrays
{
    class Program
    {
        //Multidimensional Arrays
        static void Main(string[] args)
        {
            int[ , , ] sayilar = { { {2,3 },{ 4,5 } } ,{ {4,5},{6,7} },{ {6,7},{8,9} } };

           // Console.WriteLine(sayilar[1,0]);

            for(int i=0; i<3 ; i++)
            {
                for(int j=0; j<3 ;j++)
                {
                   Console.Write(sayilar[i, j]+ " ");
                }
            }

            Console.ReadLine();
        }
    }
}
