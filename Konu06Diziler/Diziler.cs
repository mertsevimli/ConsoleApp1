namespace Konu06Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diziler - Arrays!");
            int sayi = 18;
            int[] ogrenciler = new int[6]; // örnek dizi oluşturma. 6 elemanlı int veri taşıyabilen bir dizi
            ogrenciler[0] = 100; // öğrenciler dizisindeki ilk alana 100 değerini atadık.ogrenciler[0] = 100;
            ogrenciler[1] = 200;
            ogrenciler[2] = 300;
            ogrenciler[3] = 400;
            ogrenciler[4] = 500; // bir dizide aynı değerler bulunabilir.
            ogrenciler[5] = 500;// bir dizide aynı değerler bulunabilir.
            //ogrenciler[6] = 600;// bir dizinin 6 eleman alması 6. elemanı doldurmamızı sağlamaz hata alırız indexler 0 dan basladığı için
            System.Console.WriteLine("ogrenciler[5] = " + ogrenciler[5]);
            System.Console.WriteLine("ogrenciler[1] = " + ogrenciler[1]);
            ogrenciler[5] = 600; // kod akışında dizideki elemanların değeri değiştirebiliriz.
            System.Console.WriteLine("ogrenciler[5] = " + ogrenciler[5]);
            string[] isimler = new string[6];
            isimler[0] = "Batuhan";
            isimler[1] = "Alparslan";
            isimler[2] = "Murat";
            isimler[3] = "Beyza";
            System.Console.WriteLine("isimler[3] ; " + isimler[3]); // [] dizilerde kullanıyoruz.blok olarak 
            isimler[3] = "Beyza Aktaş";
            System.Console.WriteLine("isimler[3] ; " + isimler[3]);
            System.Console.WriteLine("isimler[5] ; " + isimler[5]);
            System.Console.WriteLine();
            string[] kategoriler = { "Elektronik", "Bilgisayar", "Telefon" }; // diğer dizi tanımlama yöntemi
            System.Console.WriteLine("Kategoriler[1] : " + kategoriler[1]);
            kategoriler[1] = "Laptop";
            System.Console.WriteLine("Kategoriler[1] : " + kategoriler[1]);

            string[] urunler = { " ürün 1", "ürün2", "ürün3" };
            System.Console.WriteLine("urun 2 : " + urunler[1]);
        }
    }
}
