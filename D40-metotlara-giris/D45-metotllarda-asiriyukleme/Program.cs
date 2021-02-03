using System;

namespace D45_metotllarda_asiriyukleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isimSoyle("DİYAR YILDIRIM" ));

            Console.ReadLine();
        }
        static string isimSoyle(string isim)
        {
            return "tek parametreli metot : " + isim;
        }
        static string isimSoyle(string isim, string soyIsim)
        {
            return "İki parametreli metot"+ isim + "  " + soyIsim;
        }
    }
}
