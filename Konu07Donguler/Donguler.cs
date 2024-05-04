using System.Xml;

namespace Konu07Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Döngüler!");
            System.Console.WriteLine("1-For Döngüsü");
            for (int i = 1; i <= 10; i++)  //  döngü tanımlama 3 bloktan oluşuyor.
            // int i = 0;  bildiğimiz değişken tanımlama. 
            //i < 10 ; i nin değeri 10 sayısından küçük olduğu sürece dönmeye devam et.
            // i++ : her döndüğünde i nin değerini 1 artır ki sonsuz döngü olsun
            {
                System.Console.WriteLine("i nin değeri : " + i);
            }
            System.Console.WriteLine();
            System.Console.WriteLine("2- While Döngüsü");
            int j = 0; // değişkeni dışarıda tanımlıyoruz.
            while (j < 5)// j nin değeri 5 den küçük olduğu sürece döngü çalışacak
            {
                System.Console.WriteLine("j nin değeri : " + j); // j nin değerini yazdırdık.
                j++; // sonsuz döngüye girmemek için j yi her dönüşte 1 artırıyoruz.
            }
            System.Console.WriteLine();

            System.Console.WriteLine("3-Do While Döngüsü");
            int toplam = 10;// değişkeni döngü dışında tanımlıyoruz.
            do
            {
                System.Console.WriteLine("toplamin değeri : " + toplam); // do kısmı her halükarda 1 kere  çalışır. Şarta uyulmasa bile. Önce buradaki kodlar çalışır.

            } while (toplam < 10);// sonra şarta bakar.

            // while veri tabanında kullanılır. For genellikle kullanıyoruz.
            System.Console.WriteLine();
            System.Console.WriteLine("4-Foreach Döngüsü");
            string[] kategoriler = { "Elektronik", "Bilgisayar", "Telefon", "Televizyon", "Mobilya" };
            // Dizi veya Liste formatındaki verileri yazdırmak için kullanılır.
            foreach (string k in kategoriler)
            {
                //System.Console.WriteLine("Kategori Adı: " + k);
                System.Console.WriteLine(k + ""); // elimizde  dizi olarak veri varsa foreach kullanıyorsunuz
            }

            System.Console.WriteLine();
            System.Console.WriteLine("İç İçe Döngü");
            string[] urunler = { "ürün 1", "ürün 2", "ürün 3" };
            foreach (string k in kategoriler) // kategöri listesinde dön
            {
                System.Console.WriteLine(k);// kategori ekrana yazdır.
                foreach (var urun in urunler) // ekrana yazdırılan kategoriye ait ürünlerde dön
                {
                    System.Console.WriteLine(urun); // ilgili kategoriye ait ürünleri alt alta yazdır.
                }
}

        }

    }
}
