namespace Konu10StringSinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("String Sınıfı!");
            string degisken;
            char karakter = 'z';
            string metin = "String yan yana dizilmiş char yapısıdır.";
            //Ornek();
            StringMetotlari();
        }


        static void Ornek()
        {
            string birMetin = "Ankara Başkenttir.";
            string birSayi = "123456789";
            System.String birTarih = "05.05.2024"; // string system kütüphanesinde bulunur.
            System.Console.WriteLine("birMetin veri tipi: " + birMetin.GetType());
            System.Console.WriteLine("birSayi veri tipi: " + birSayi.GetType());
            System.Console.WriteLine("birTarih veri tipi: " + birTarih.GetType());
            string s = "Barış Manço";// s karakterlerden oluşan bir dizidir.
            System.Console.WriteLine("s: " + s);
            for (int i = 0; i < s.Length; i++) // s değişkenindeki karakter kadar dön
            {
                System.Console.WriteLine($"s[{i}] : {s[i]}");// döngü her döndüğünde ilgili  indexteki karakteri ekran yazdır.s[i] kodu s değişkenindeki i. karakteri ekrana yazar.

            }
            foreach (var item in s)//foreach ile s değişkenindeki her bir karakteri ekran yazdırabiliriz.
            {
                System.Console.WriteLine(item);// item s değişkenindeki her bir karaktere karşılık gelir.
            }
        }
        static void StringMetotlari()
        {
            string metin = "Stringin birçok metodu vardır.";
            System.Console.WriteLine("metin: " + metin);
            System.Console.WriteLine("metnin karakter sayısı : " + metin.Length); // Length bize değişkenin kaç karakterden oluştuğu bilgisini verir.
            var klon = metin.Clone();
            System.Console.WriteLine("metnin klonu : " + klon);
            metin = "My name is ALp";
            System.Console.WriteLine("metin: " + metin);
            System.Console.WriteLine("metin p ile bitiyor mu : " + metin.EndsWith('p'));
            System.Console.WriteLine("metin r ile bitiyor mu : " + metin.EndsWith('r'));
            System.Console.WriteLine();

            System.Console.WriteLine("metin s ile başlıyor mu : " + metin.StartsWith('s'));
            System.Console.WriteLine("metin M ile başlıyor mu : " + metin.StartsWith('M'));

            System.Console.WriteLine("metin IndexOf('i') : " + metin.IndexOf('i')); // metin değişkeni içinde ilgili karakterin başladığı index değerini veriyor.
            System.Console.WriteLine("metin IndexOf(\"name\") : " + metin.IndexOf("name"));
            System.Console.WriteLine("metin IndexOf(\"var\") : " + metin.IndexOf("var")); // Eğer bulamazsa -1 değeri döndürüyor
            System.Console.WriteLine("metin LastIndexOf('i') : " + metin.LastIndexOf('i'));// i nin geçtiği en son index numarası 
            System.Console.WriteLine("metin.Insert" + metin.Insert(0, "Merhaba ")); // değişkene verdiğimiz index numarasından itibaren ilgili değeri ( Merhaba ) ekle ( insert metodu metnin değerini değiştirmez!)
            System.Console.WriteLine("metin: " + metin);
            System.Console.WriteLine("metin.Substring " + metin.Substring(2)); // metnin içinde verilen indexteki karakterlerden itibaren kalan kısmı parçalayıp bize getirir.
            System.Console.WriteLine("metin.Substring " + metin.Substring(2, 5)); // 1. parametre metnin içinde kaçıncı sırada başlayacak , 2 . parametre kaç karakter uzunluğunda parça alınsın.

            System.Console.WriteLine("metinToLower() metindeki tüm karakterleri küçük harf yapar : " + metin.ToLower());
            System.Console.WriteLine("metinToUpper() metindeki tüm karakterleri büyük harf yapar : " + metin.ToUpper());
            System.Console.WriteLine("metin: metin.ToLower().Replace(\"\", \"-\") " + metin.ToLower().Replace(" ", "-"));// Replace metodu ilk parametrede gördüğü karakteri 2. parametrede verdiğimizle değiştirir.
            System.Console.WriteLine("metin.Remove(2, 5)verilen indexten itibaren 5 karakteri sil: " + metin.Remove(2, 5));

            string sehirler = "İstanbul,Ankara,İzmir,Çankırı,Karabük";
            System.Console.WriteLine("Şehirler:" + sehirler);
            string[]sehirlistesi = sehirler.Split(","); // Split metodu kendisine verilen karakter ile ayrılmış olan verileri o karaktere göre parçalayıp sehirlistesi dizisine atar.
            System.Console.WriteLine("Seçilen Şehir: " + sehirlistesi [4]);
            foreach (var sehir in sehirlistesi)
            {
                System.Console.WriteLine(sehir);
            }



        }
    }
}