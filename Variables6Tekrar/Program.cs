using System;

namespace Variables6Tekrar
{
    class Program
    {
        static void Main(string[] args)
        {

            // ön tanımlı veritipleridir..
            // sbyte, byte,short,ushort, int, uint,long,ulong
            // double, decimal, float

            // string
            // char (tek karakter)

            //bool (true,false)

            // value type(değer tipler) => sadece değer tutan tiplerdir...
            // sbyte, byte,short,ushort, int, uint,long,ulong, double, decimal, float, char, bool


            // reference type(referans tipler) => değer yerine refarans tutan tiplerdir...
            //string (birden fazla karakterin referansını tutar....

            int de = 3;
            int a = de;
            de++;
            Console.WriteLine(a); // 3,

            byte b = 3;
            int i = 200000;

            double d = 3.1; // yorumlayıcımız 3.1'i double olarak yorumlar.. eğer kullanacağımız değer double dışında bir tip olacaksa değer atandığında float ve decimal'ın arka ekini kullanmamız gerekir..
            float j = 3.1f;
            decimal k = 3.1m;

            Console.WriteLine("Hello World!");
        }
    }
}
