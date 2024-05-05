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
            Ornek();
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
            for (int i = 0; i < s.Length; i++) // s değişkenindeki karakter kadar dön
            {
                System.Console.WriteLine($"s[{i}] {s[i]}");// döngü her döndüğünde ilgili  indexteki karakteri ekran yazdır
            }
        }

    }
}