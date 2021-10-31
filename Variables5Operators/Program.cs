using System;

namespace Variables5Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OPERATÖRLER");

            int a = 1; // atama opetarü
            a = 4; // atama operatörü
            a += 4; // a'yı 4 ile topla ve ata

            // aritmatik operatörler
            int i = 2, j = 2;
            int sonuc;
            sonuc = i + j; // toplama
            sonuc = i - j; // çıkarma
            sonuc = i * j; // çarpma
            sonuc = i / j; // bölme
            sonuc = i % j; // mod alma, bölümden kalanı verir

            sonuc = sonuc + 1;
            sonuc += 1;

            sonuc++; // tek artım...
            sonuc--; // tek azalım...

            int x = 1;
            int y = x++; //artım işlemi bir sonraki satıra yansır... önce ata, sonra arttır..
            Console.WriteLine("X = " + x); // 2
            Console.WriteLine("Y = " + y); // 1


            Console.WriteLine("********************");

            int k = 1;
            int l = ++k;
            Console.WriteLine("K = " + k); // 2
            Console.WriteLine("L = " + l); // 2

            // KARŞILAŞTIRMA OPERATÖRLERİ
            // iki değeri karşılaştırmak için kullanılır... sonuç her zaman true veya false döner... true ve false değerleri sadece bool değişkenlerde tutulabilir....
            bool b1 = true;
            bool b2 = false;

            int sayi1 = 3;
            int sayi2 = 4;
            int sayi3 = 5;

            bool durum;
            durum = sayi1 > sayi2; //  false büyük
            durum = sayi1 < sayi2; //  true  küçük
            durum = sayi1 >= sayi2; // false büyükeşit
            durum = sayi1 <= sayi2; // true  küçükeşit
            durum = sayi1 == sayi2; // false == (eşitlik operatörü)
            durum = "A" == "a";    //  false
            durum = "b" == "b";    // true;
            durum = sayi1 != sayi2; // true eşitdeğil

            //durum = sayi1 > sayi2 > sayi3; ikiden fazla değeri karşılaştırmak istiyorsak mantıksal operatörleri kullanmalıyız...
            //MANTIKSAL OPERATÖRLER
            // iki ve daha fazla değeri karşılaştırmak için kullanılır...
            // and (ve)   && (shift + 6)
            // or  (veya) || (AltGr + KüçükBüyük veya AltGr + - tuşu )
            durum = sayi1 > sayi2 && sayi1 > sayi3; // FALSE
            durum = 3 > 1 && 3 > 2;       //TRUE
            durum = 2 < 1 && "A" == "A";  // FALSE
            durum = "a" != "A" && 1 == 1; //TRUE

            durum = sayi1 > sayi2 || sayi1 > sayi3;// FALSE
            durum = 3 > 1 || 3 > 2; // TRUE
            durum = 2 < 1 || "A" == "A"; // TRUE;
            durum = "a" != "A" || 1 == 1; // TRUE

            Console.ReadKey();
        }
    }
}
