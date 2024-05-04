using System.Data;

namespace Konu08Siniflar;

internal class SiniftaMetotKullanimi
{
string kurucuMetot;// constructor
string sistemdekiKullaniciAdi;
string sistemdekiSifre;
// ctor tab tab kurucu metot oluşturmanın kısayolu
public SiniftaMetotKullanimi()// kurucu metotların void veya geri dönüş değeri yoktur.
{
    kurucuMetot = "kurucu metotlar sınıftan alınan her nesne örneğinde ilk çalışan metotlardır.";
    System.Console.WriteLine(kurucuMetot);
    System.Console.WriteLine();
    sistemdekiKullaniciAdi = "Admin";
    sistemdekiSifre = "Adm123";
}
public bool LoginKontrol(string KullaniciAdi,string Sifre)
{
    if(KullaniciAdi == "Admin"&&Sifre == "Adm123") // metoda dışarıdan gönderilecek değerler bunlara eşitse
    {
    return true ; // girişe izin ver
    }
    return false;
}
public int ToplamaYap(int sayi1 , int sayi2 )
{
    return sayi1 + sayi2;
}
}
