using System;

namespace Variables2
{
    class Program
    {
        static void Main(string[] args)
        {
            // solution penceresinde birden falza proje varsa, projelerden birtanesi (ilk oluşturulan) varsayılan proje olarak kabul edilir. start düpmesine tıklandığında açılmasını istediğiniz projenize sağ tık yapıp set as startup project seçeneğini kullanabiliriz... 
            Console.WriteLine("Değişken oluşturma kuralları");

            // değişkenler bizim bellekteki adres temsilcilerimizdir...değişkenlerdeki  değerlerimiz ram'de tutulur...

            // değişken isimlerinde harf, rakam ve özel karakterlerden _ kullanılabilir..

            // kural1
            // değişken isimleri rakam ile başlamaz...
            //int 1sayi;
            int sayi1;
            int sayi2A;


            // kural2
            // değişken isimleri unique (benzersiz) olmalıdır
            int sayi2;
            //byte sayi2; sayi2 ismi daha önce oluşturulduğu için aynı isimde değişken oluşturulamaz...

            //kural3
            // değişken isimlerinde reserved keywords kullanılanamaz... reserved keywords => c# dilinde tanımla isimlerdir...int vb..
            //byte int= 1;

            // Ancak illa kullanılacaksa değişken isminin başına @ ifadesi atılır. Ama tavsiye etmiyorum...
            int @int = 1;
            @int = 2;

            int a;
            // c# case sensetive bir dildir. büyük küçük harf duyarlılığı vardır. Yani a ile A farklı şeylerdir..
            int A;


            // değişken oluştururken isimlendirme standartları...
            // camelCase
            // PascalCase

            string Ad; //PascalCase
            string AdSoyAd; // PascalCase

            string ad; // camelCase
            string adSoyAd; // camelCase

            // örnek değişken
            int sayi; // değişken oluşturduk..
            sayi = 2; // değişkene değer atadık..

            int b = sayi; // sayinin değerini b'ye atadık...
            b = 3;
            Console.WriteLine(sayi); // 

            // tek satırda birden fazla değişken oluşturma
            int i, j, k; // i, j, k değişkenlerinin tipleri ortaktır. Kod satırını arttırmamak için başvurulabilir

            int x = 1, y = 2, z = 3;
            // NOT : değişenlerin ömrü iki scope arası kadardır..

            Console.ReadKey();
        }
    }
}
