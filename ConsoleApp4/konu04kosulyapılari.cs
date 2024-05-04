System.Console.WriteLine("Koşul Yapıları!");
System.Console.WriteLine("Program yazarken duruma göre farklı akışlardan devam edebilmemizi sağlayan yapılardır.");
/*
System.Console.WriteLine(" Lütfen Bir Sayı Giriniz:");

var sayi = int.Parse(Console.ReadLine());// Consele.Readline () kullanıcının ekrandan yazdığı yazıyı okumayı sağlar.
if (sayi > 0)
{
    System.Console.WriteLine("Girilen sayı Pozitif");
}

else if (sayi == 0) // if ten sonra else if istediğimiz kadar kullanabiliriz.
{
    System.Console.WriteLine("Girilen Sayı 0");
}
else
{
    System.Console.WriteLine("Girilen Sayı Negatif");
}
*/

// ****-----------------//
/*
System.Console.WriteLine("Kullanıcı Adınızı Giriniz : ");
string kullaniciAdi = Console.ReadLine();
System.Console.WriteLine("Şifrenizi Giriniz : ");
string sifre = Console.ReadLine();
if (kullaniciAdi == "mert" && sifre == "123")
{
    System.Console.WriteLine("Giriş Başarılı");
    System.Console.WriteLine(" Hoşgeldin " + kullaniciAdi);
}
else
{
    System.Console.WriteLine("Giriş Başarısız!");
    System.Console.WriteLine(" Girilen Bilgiler Hatalı! Lütfen tekrar Deneyiniz..");
}*/

System.Console.WriteLine("Switch Case"); // BU ÇOK ÖNEMLİİ !!!!
System.Console.WriteLine("Tarih : " + DateTime.Now); // Sistemde o andaki tarih ve saat bilgisini bu şekilde elde ediyoruz.
int ay = DateTime.Now.Month; // o andaki ay bilgisini aldık.
switch (ay) // Bu yapıda ay değişkenin değeri alınıp aşağıda case lerle deneme yanılma yöntemiyle tek tek kontrol ediliyor.
{
    case 12: // ay değeri 12-1-2 değerlerinden biriyse
    case 1:
    case 2:
    System.Console.WriteLine("Mevsim Kış");// buradaki kodu çalıştır.
    break;// ve aşağıya doğru akışı break komutuyla kır kodu çalıştırmaya devam etme
    case 3:
    case 4:
    case 5:
    System.Console.WriteLine("Mevsim İlkbahar");
    break;
    case 6:
    case 7:
    case 8:
    System.Console.WriteLine("Mevsim Yaz");
    break;
    case 9:
    case 10:
    case 11:
    System.Console.WriteLine("Mevsim Sonbahar, Pencerede damlalar..");
    break;
    default:// default yapısı if else deki else mantığında çalışır yukarıdaki şartların hiç biri tutmazsa bu blok devreye girer.
    System.Console.WriteLine("Bir hata oluştu");
    break;

}