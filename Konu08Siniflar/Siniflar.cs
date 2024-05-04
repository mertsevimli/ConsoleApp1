namespace Konu08Diziler
{
    class Ev // kendi sınıfımızı bu şekilde oluşturuyoruz
    {
        string sokakAdi; // bu sınıfta kullanmak istediğimiz değişkenler
        string kapiNo;
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


        }



    }
}
