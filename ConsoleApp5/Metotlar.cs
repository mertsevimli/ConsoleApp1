namespace Konu05Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Methodlar!");//  Writeline .net içerisinde bize sunulmuş bir methoddur.
            System.Console.WriteLine("Bir işi yapan kodları bir araya getirip tekrar tekrar kullanabilmemizi sağlayan yapılardır.");
            System.Console.WriteLine(" Dışarıdan göndereceğimiz parametre değerlerine göre de çalışabilirler. ");
            System.Console.WriteLine(" Geride değer döndüren ve döndürmeyen metotlar olarak temelde ikiye ayrılırlar");

            System.Console.WriteLine("1. toplama yap metodu ToplamaYap");
            ToplamaYap();// Metotlar çağrılmadığı sürece çalışmaz!ToplamaYap(100, 18);// C# metoda gönderdiğimiz parametrelerden aşağıdaki metotlardan hangisini çalıştırcağını bulur.

            System.Console.WriteLine("2. Toplama yap metodu ToplmaYap (100,18)");
            ToplamaYap(100, 18);// C# metoda gönderdiğimiz parametrelerden aşağıdaki metotlardan hangisini çalıştırcağını bulur.

            System.Console.WriteLine("3. toplama yap metodu ToplamaYap ()");
            ToplamaYap();

            System.Console.WriteLine("4. Toplama yap metodu ToplamaYap (1000, 18, 200)"); //ToplamaYap(1000, 18, 200);
            System.Console.WriteLine(ToplamaYap(1000, 18, 200));
            //     System.Console.WriteLine("1.sayısı giriniz.");
            //     var sayi1 = int.Parse(Console.ReadLine());
            //     System.Console.WriteLine("2. sayıyı giriniz.");
            //     var sayi2 = int.Parse(Console.ReadLine());
            //     System.Console.WriteLine("3. sayıyı giriniz");
            //     var sayi3 = int.Parse(Console.ReadLine());

            //     var sonuc = ToplamaYap(sayi1, sayi2 , sayi3 ); // toplama yap metodundan dönen değeri bir değişkene atadık
            //     System.Console.WriteLine(sonuc);// ve bu değişkendeki değeri ekrana yazdırdık.
            // 

            //
            // System.Console.WriteLine("Mail adresini giriniz:");
            // var mailAdresi = Console.ReadLine();
            // bool MailGonderildimi = MailGonder(mailAdresi);
            // if (MailGonderildimi == true)
            // {
            //     System.Console.WriteLine(mailAdresi+ "adresine mailiniz gönderilmiştir.");

            // }
            //     else
            //     {
            //         System.Console.WriteLine("Mail Gönderilmedi");
            //     }
            //KdvHesapla();
            var deger = SmsKoduUret();
            System.Console.WriteLine("Değer : " + deger);
        }
        static void ToplamaYap()// örnek metot tanımlaması. Static ifadesi yukarıda kullanabilmemiz için gerekli, void ifadesi bu metodun geriye bir değer döndürmeyeceğini tek işlem yapacağını belirtir.
                                // ToplamaYap ise metodumuzun adıdır.
        {
            System.Console.WriteLine(10 + 8);
        }
        static void ToplamaYap(int sayi1, int sayi2)// örnek metot tanımlaması. Static ifadesi yukarıda kullanabilmemiz için gerekli, void ifadesi bu metodun geriye bir değer döndürmeyeceğini tek işlem yapacağını belirtir.
                                                    // ToplamaYap ise metodumuzun adıdır.
        {
            System.Console.WriteLine(sayi1 + sayi2);
        }
        static int ToplamaYap(int sayi1, int sayi2, int sayi3) // geriye değer döndüren metot 
        {
            // ToplamaYap metot adının önündeki  int ifadesi bu metotdun geriye int veri tipinde bir değer döndüreceğini belirtir.
            System.Console.WriteLine();
            return sayi1 + sayi2 + sayi3; // geriye değer döndüren metodlarda en altta return ifadesi kullanıp sonrasına metodun göndereceği veri tipi neyse
                                          //(int ,string,bool vb) o tipte bir değer döndürmeliyiz yoksa kızarır hata verir.
        }
        static bool MailGonder(string email)
        {
            if (!string.IsNullOrEmpty(email))// burada   IsNullOrEmpty metodu .net de var olan ve string bir değişkenin boş olup olmadığını kontrol eden bir metotdur.
            {
                // burada .net içerisindeki mail gönderme kodları çalıştırılır.
                return true; // işlemler tamamlandıktan sonra metot geriye true değeriyle işlem başarılı bilgisi gönderir.
            }
            return false;
        }
        static void KdvHesapla()
        {
            double fiyat, kdv, toplam;// değişken tanımlarken aynı tipler bu şekilde araya , koyarak birden fazla değişken tanımlayabiliriz.
            System.Console.WriteLine("Ürün fiyatını giriniz:");
            fiyat = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Kdv miktarını giriniz : ");
            var kdvMiktari = Convert.ToDouble(Console.ReadLine());
            kdv = fiyat * kdvMiktari / 100;
            toplam = fiyat + kdv;
            System.Console.WriteLine("Ürün kdv tutarı: " + kdv + " ₺ ");
            System.Console.WriteLine("Kdv dahil fiyatı : " + toplam + " ₺");

        }
        static string SmsKoduUret()
        {
            Random random = new Random();// Random sınıfı rastgele sayı üretmeyi sağlayan bir .net sınıfıdır.
            int sayi1 = random.Next(0, 9);
            int sayi2 = random.Next(0, 9);
            int sayi3 = random.Next(0, 9);
            int sayi4 = random.Next(0, 9);
            int sayi5 = random.Next(0,99999);

            //return $"{sayi1}{sayi2}{sayi3}{sayi4}";
            return sayi5.ToString(); 
        }

    }
}