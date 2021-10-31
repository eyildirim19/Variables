using System;

namespace Variables4TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string deger = "1";
            //  int b = deger; tip farklılığı olduğu için atama işlemi yapılamaz...
            //int b = (int)deger;

            // + operatörü dğerler string ise birleştirme sayı ise toplama işlemi yapar...

            // ReadLine metodu ekrandan girilen değeri string olarak verir..

            // string ifadeler int'e dönüşebilmesi için tür dönüşümüne ihtiyacımız vardır..
            Console.WriteLine("1. Sayıyı Giriniz");
            int sayi1 = int.Parse(Console.ReadLine()); // consoledan girilen string değeri int'e dönüştür

            Console.WriteLine("2. Sayıyı Giriniz");
            int sayi2 = int.Parse(Console.ReadLine()); // 

            int sonuc = sayi1 + sayi2; // işlem yapıyoruz...
            Console.WriteLine("İşlem sonucunuz" + sonuc);

            // dönüşümlerde bilmemiz gerekenler...
            string sabitSayim = "444";
            int a = int.Parse(sabitSayim);

            string str = "DEMO";
            // int b = int.Parse(str);  // format hatası alırız. DEMO değeri sayısal formatta değildir. sadece sayısal formattaki metinler dönüştürülebilir...

            Console.ReadKey();
        }
    }
}
