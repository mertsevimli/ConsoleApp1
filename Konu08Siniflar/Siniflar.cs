using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Konu08Siniflar;

namespace Konu08Diziler
{
    class Ev // kendi sınıfımızı bu şekilde oluşturuyoruz
    {
        internal string sokakAdi; // bu sınıfta kullanmak istediğimiz değişkenler
        internal string kapiNo;
    }
    // Erişim Belirteçleri : Sınıflar ve içindeki öğelerine (metot, özellik, değişken vb)  nerelerden erişilebilir. veya erişilemez ayarını yapılandırmamızı sağlar.
    /*
    * Public : Erişim kısıtı yoktur, her yerden erişilebilir.
    * Protected : Ait olduğu sınıftan ve o sınıftan türetilen sınıflardan erişilebilir.
    * İnternal : Etkin Projeye ( Aynı namespace altındakiler) ait sınıflardan erişilebilir.
    * Private : Yalnız bulunduğu sınıftan erişilebilir. Dışarıdan erişimlere kapalıdır.
    */
    internal class Program // 1 sınıf tanımı  bu şekilde 3 yapıdan oluşur.internal : erişim belirteci , Class : Sınıf yapısı, Program  : sınıfımızın ismi
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Sınıflar , Classes");
            Ev ev = new Ev();// Bir sınıftan bir nesne oluşturma
            ev.sokakAdi = "internal sk."; // ev nesnesinin içindeki sokakAdi değişkenine değer atama
            ev.kapiNo = "18";

            System.Console.WriteLine("ev in bulunduğu sokak : " + ev.sokakAdi);// değişken değerini ekrana yazdırma
            System.Console.WriteLine("Kapı No : " + ev.kapiNo);

            Ev koyEvi = new Ev(); // Bir class tan 1 den fazla nesne oluşturabiliyoruz.
            koyEvi.sokakAdi = "Köy Yolu Sk.";
            koyEvi.kapiNo = "3";

            System.Console.WriteLine("Köy Evi Bilgileri : " + koyEvi.sokakAdi + "" + koyEvi.kapiNo);
            Ev yazlik = new Ev()// Sınıftan nesne tanımlamanın diğer yöndemi
            {
                sokakAdi = "Bodrum cad. yalıkavak", // burada bu şekilde değişkenlere değer atayabiliyoruz.
                kapiNo = "3" // değişkenler arasında virgül kullanarak ayırıyoruz , en son değişkenden sonra virgüle gerek yok !
            };

            System.Console.WriteLine($"Beyza nın yazlik bilgileri : {yazlik.sokakAdi} {yazlik.kapiNo}");
            System.Console.WriteLine();
            Kategori kategori = new Kategori();
            kategori.Adi = "Elektronik";

            System.Console.WriteLine("kategori.Adi = " + kategori.Adi);
            Kullanici kullanici = new Kullanici();
            kullanici.Adi = "Beyza";
            kullanici.Soyadi = "Erdem";
            kullanici.KullaniciAdi = "berdem";
            kullanici.Sifre = "be123";

            System.Console.WriteLine("Kullanıcı Bilgileri:");
            System.Console.WriteLine($"{kullanici.Adi} {kullanici.Soyadi}");

            Kullanici kullanici2 = new Kullanici()
            {
                Adi = "Murat",
                Soyadi = "Yılmaz",
                Email = "my@hotmail.com"
            };

            System.Console.WriteLine("2.Kullanıcı");
            System.Console.WriteLine($"{kullanici2.Adi} {kullanici2.Soyadi} \n Email: {kullanici2.Email}"); // String metin içindeki \n kodu sonrasındaki metni alt satıra geçirir.
            System.Console.WriteLine("Beyzanın Araç Bilgileri : ");
            Araba araba = new Araba()
            {
                Marka = "Dacia",
                KasaTipi = "Sedan",
                Model = "Logan",
                VitesTipi = "Otomatik"
            };
            System.Console.WriteLine($"{araba.Marka} {araba.Model}");
            Araba yerliveMilli = new Araba()

            {

                Marka = "TOGG",
                KasaTipi = "SUV",
                Model = "T10X",
                VitesTipi = "Otomatik"

            };
            Console.WriteLine($"Yerli Araç: " + yerliveMilli.Marka + " " + yerliveMilli.Model);

            SiniftaMetotKullanimi metotKullanimi = new();
            System.Console.WriteLine("metotKullanimi: " + metotKullanimi.ToplamaYap(10, 8));
            System.Console.WriteLine();
            System.Console.WriteLine("Kullanıcı Adınızı Giriniz");
            var KullaniciAdi = Console.ReadLine();

            System.Console.WriteLine("Şifrenizi Giriniz : ");
            var kullaniciSifre = Console.ReadLine();

            bool sonuc = metotKullanimi.LoginKontrol(KullaniciAdi, kullaniciSifre);
            System.Console.WriteLine("Login kontrol : " + (sonuc == true ? "Giriş Başarılı.. " : "Giriş Başarısız!"));



        }// main class bitişi
    } // program clası bitiş
    class Kullanici
    {
        // Property ler : Prop tab tab kısayolu ,sınıflarda değişkenler dışında kullanabileceğimiz değer atayıp okuma yapabileceğimiz özelliklerdir.
        public int Id { get; set; }
        public string Adi { get; set; } // bir property e dışarıdan veri atanırsa set bloğu, üzerindeki veri okunmak istenirse get bloğu çalışır.
        public string Soyadi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }

    }
    class Araba
    {
        internal int Id { get; set; }
        internal string Marka;
        internal string Model;
        internal string KasaTipi;
        internal string YakitTipi;
        internal string VitesTipi;
        internal string Renk;
    }
}
