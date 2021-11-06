using System;

namespace Variables8Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //int a = int.Parse("A"); // dönüşüm yapılamaz...çünkü A sayı formatında değildir...

            int a = int.Parse("3"); // 3 değerini tam sayıya çevirdik..


            //Convert => dönüşüm sınıfıdır..verileri farklı tiplere dönüştürmek için kullanılır...
            bool bl = false;

            int b = Convert.ToInt32("3"); //3'ü inte dönüştür
            int c = Convert.ToInt32(bl);


            byte by = Convert.ToByte("20"); // byte dönüşüm
            sbyte sb = Convert.ToSByte("20"); // sbyte dönüşüm

            // veritipi ile cts adı farklı olan dönüşüm metotlarımız
            //Convert.ToInt16 short dönüşüm yapar...
            //Convert.ToInt32 int dönüşüm yapar...
            //Convert.ToInt64 long dönüşüm yapar

            //Convert.ToSingle float dönüşüm yapar...
            //Convert.ToBoolean bool tipinde dönüşüm yapar..

            Console.ReadKey(); // bekleme
        }
    }
}
