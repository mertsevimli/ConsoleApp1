using System.Net.WebSockets;

namespace Konu17HataYonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hata Yönetimi!");
            System.Console.WriteLine(".net içerisinde programımız çalışırken veri ve tipleriyle çalışırken sıklıkla hatalarla karşılaşabiliriz. Bu gibi durumlarda oluşan hatayı yakalama , gerekirse bir yere kaydetme , hata durumlarında yazılımcıya vb bildirim gönderme gibi işlemleri yapabilceğimiz bir sistem mevcuttur.");

            System.Console.WriteLine("Hesaplanacak Değeri Giriniz : ");
            var deger = Console.ReadLine();



            // KdvHesaplama(double.Parse(deger));// Eğer ekrandan kullanıcı sadece sayısal değer değil string TL ₺ gibi bir değer  de gönderirse uygulama çöker !!!! Bunu engellemek için programlamada try catch yapısı kullanılır.

            try  // try yaz tab tab
            {
                //uygulama çalışığında önce buradaki try bloğu içerisindeki kodlar çalışır.
                // eğer bir hata yoksa uygulama çalışmasına devam eder.
                KdvHesaplama(double.Parse(deger)); // meetot çalıştığında bir hata oluşursa bu sefer catch bloğu çalıştırılır.
            }
            catch (Exception hata) // oluşan hatayı bu şekilde hata nesnesiyle yakalarız.
            {

                // burada yakaladığımız hata ile ne yapmak istersek o işlemi  yapabiliriz.
                // hata oluştuğunda sadece uygulama çöküşünü engellemek istersek herhangi bir  işlem yapmamıza gerek yok
                //throw; // throw kodu hata fırlatmayı sağlar, eğer hata fırlatmak istemiyorsak bu satırı kaldırmalıyız.!!!
                System.Console.WriteLine("Bir hata oluştu!");
                System.Console.WriteLine("Lütfen sadece sayısal değer girerek tekrar deneyiniz!!");
                System.Console.WriteLine(hata.Message);//istersek hata mesajını ekrana bastırabiliriz.

                try
                {  
                    HatayiLogla(hata);// hatayı loglayacağımız metodu birçok hata alanında kullanabiliriz.
                 }
                 catch {
                    // eğer hatayı loglarken bir hata alırsak sadece uygulama çökmesini engelle ve uygulama çalışmasına devam etsin
                 }

                HatayiLogla(hata); // hatayı loglayacağımız metodu birçok hata alanında kullanabiliriz.

            }
            finally
            {
                System.Console.WriteLine("try catch bloğundan sonra her seferinde çalışmasını istediğimiz bir işlem varsa bu blokta çalıştırabiliriz.Kullanımı zorunlu değildir.");
            }

        }
        static void HatayiLogla(Exception exception)
        {
            //burada gelen exception nesnesinin detaylarını veya kendisini veritabanındaki bir tabloya kaydedebiliriz.
            // veya txt dosyası olarak uygulamanın çalıştığı cihaza kaydedebiliriz.
            //oluşan hata bilgilerini uygulama ekibine maille hemen bildirebiliriz.
            //bu işlemlere hata loglama denir.

            System.Console.WriteLine();
            System.Console.WriteLine("Detaylı hata bilgileri : ");
            System.Console.WriteLine("exception.Message: " + exception.Message);
            System.Console.WriteLine();
            System.Console.WriteLine("exception.InnerException: " + exception.InnerException);
            System.Console.WriteLine();
            System.Console.WriteLine("exception.Source : " + exception.Source);
            System.Console.WriteLine();
            System.Console.WriteLine("exception.HResult : " + exception.HResult);
            System.Console.WriteLine();
            System.Console.WriteLine("exception.StackTrace : " + exception.StackTrace);
            System.Console.WriteLine();
            System.Console.WriteLine("exception.TargetSite : " + exception.TargetSite);
            System.Console.WriteLine();
            System.Console.WriteLine("exception.HelpLink : " + exception.HelpLink);
            System.Console.WriteLine();
            System.Console.WriteLine("Exception" + exception);
        }

        static void KdvHesaplama(double fiyat)
        {
            System.Console.WriteLine("Fiyat : " + fiyat + " ₺ ");
            System.Console.WriteLine("Kdv : " + (fiyat * 0.20) + " ₺");
            System.Console.WriteLine("Kdv Dahil Ödenecek Toplam Tutar : " + (fiyat + (fiyat * 0.20)) + " ₺ ");

        }
    }

}