using System;

namespace Variables3TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int a = 1;
            int b = 2;
            a = b; // a ile b tip olarak eşit...

            // c# dilinde değişkenlerin birbirine atanabilmesi için tiplerinin birbirine eşit olması gerekir.
            string str;
            //str = a; str ve a değişkenlerinin tipleri birbirinden farklı olduğu için atama işlemi yapılamaz..

            int i; // -2 milyar küsür, 2 milyar küsür
            byte j = 200; // 0-250

            i = j; // küçük tip büyüğe atanırken otomatik dönüştürülür...

            //j = i; // büyük tip küçük tipe atanamaz...ancak atama yapmakta kararlıysak bu atamayı casting işlemi ile yaparız...

            //tpye casting = büyük tipin küçük tipe dönüşümüdür..
            j = (byte)i; // i'yi bayte dönüştür...

            // value type casting kullanırken çok dikkatli olmalıyız. çünkü veri kaybı yaşanabilir...
            // örnek
            short sht = 260;
            byte bt = (byte)sht;
            Console.WriteLine("short değer" + sht);
            Console.WriteLine("byte değer" + bt);


            Console.ReadKey();
        }
    }
}
