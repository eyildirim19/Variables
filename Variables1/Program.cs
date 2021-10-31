using System; // kütüphane kısmı. kullanılacak komutların kütüphanleri çağrılır...

namespace Variables1 //kütüphane ismi 
{
    class Program // Class adı
    {
        static void Main(string[] args) // metot
        {
            // kullanıcıdan adını isteyip, ekrana merhaba mesajı veren programı yazalım...

            Console.WriteLine("Adınız???"); // ekrana adınız çıktısı veriyoruz...
            Console.WriteLine("Hoş geldin " + Console.ReadLine()); // Console.ReadLine() input işlemleri için kullanılır. Console penceresinde veri girip enter tuşuna basıldığında girilen veriyi okur

            Console.WriteLine("1. Sayıyı Giriniz");
            Console.WriteLine("2. Sayıyı Giriniz");

            Console.WriteLine("İşlem Sonucunuz " + Console.ReadLine() + Console.ReadLine());
            // girilen iki sayıyı toplamak için öncelikle sayıları değilkenlerde tutmamız gerekir. 17. satırda değişken oluşturmadan da toplama işlemi yapabilirdik.


            // VERİ NEDİR???
            // BİLGİNİN İŞLENMEMİŞ HALİDİR. 

            // DEĞİŞKEN NEDİR 
            // dışarıdan girilen verileri tutmak için kullanılan program parçalıdır.

            // DEĞİŞKEN OLUŞTURMAK İÇİN
            // <veriTipi> <degiskenAdi> = <veri>

            int sayi = 3; // 3 değerini sayi değişkenine atadık. = operatörü sağdaki değeri soldakine atar...
            char ch = 'A';
            double duble = 3.1;

            // VERİTİPLERİMİZ...
            // TAM SAYI VERİ TİPLERİMİZ
            sbyte sb = 1;
            byte bt = 1; // 0-255 arası değer alır
            short shrt = 1;
            ushort ushrt = 1;
            int i = 1;
            uint ui = 1;
            long lg = 1;
            ulong ulg = 1;

            // ONDALIKLI VERİ TİPLERİMİZ
            float fl = 1;
            double dbl = 1;
            decimal dm = 1;

            // MANTIKSAL VERİ TİPİ
            bool bl = false; // true veya false değeri tutar....

            // METİNSEL VERİ TİPLERİ
            char ch1 = 'A';
            string str = "bt akademi";  // birden fazla karakteri tutmak için kullanılır...

            Console.ReadKey();
        }
    }
}
