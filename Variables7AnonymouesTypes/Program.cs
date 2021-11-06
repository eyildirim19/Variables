using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables7AnonymouesTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Anonim tipler

            // var ifadelerinin özelliği atana değerin tipini alır..

            var ad = "ekrem yıldırım"; // string
            var cinsiyet = 'e'; // char
            var cocuk = true; // bool
            var maas = 1000.99; // double
            var ortalama = 50.1f; // float

            // cocuk ="alp" // değişkeniminiz tipi bool olduğu için string  değer atanamaz...

            // var çok sık kullanılan bir tiptir. Nedeni anonim olmasıdır. object tabanlı uygulamalarda anlık çözümler için kullanılır...


            // var'da tip değer atandığında oluştuğu için başlangıç değerinin atanması zorunludur...
            //var ders;

            // eğer değişkeni oluşuturup değer atanmadan kullanamak isteniyorsa aşağıdaki gibi kullanılabilir...
        
            string s;
            var ders = default(string);
            
        }
    }
}
