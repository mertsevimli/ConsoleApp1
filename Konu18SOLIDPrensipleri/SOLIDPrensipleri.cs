namespace Konu17HataYonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("SOLID Presipleri!");
            System.Console.WriteLine("Robert Cecil Martin tarafından öne sürülen geliştilecek yazılımın esnek,yeniden kullanılabilir, sürdürülebilir ve anlaşılır olmasını hedefleyen kod tekrarını önleyen prensipler bütünüdür.");

            System.Console.WriteLine("SOLID bu prensiplerin baş harflerinden oluşan kısaltmalardır.");
            
            System.Console.WriteLine("S - Single Responsiblity");
            System.Console.WriteLine("1 sınıf veya metodun sadece 1 tane sorumluluğunun olması gerekir.");

            System.Console.WriteLine(" O - Open-Closed Princible");
            System.Console.WriteLine("Bir sınıf veya metot varolan özelliklerini korumalı, değişikliğe izin vermemlidir");



            System.Console.WriteLine("L- Liskov Subsition");
            System.Console.WriteLine("Kodlarımızda herhangi bir değişiklil yapmaya gerek duymadan alt sınıfları türedikleri üst sınıfların yerine kullanabilmeliyiz.");

            System.Console.WriteLine("I - Interface Segration");
            System.Console.WriteLine("Sorumlulukkarın hepsini tek bir arayüzde toplamak yerine özelleştirilmiş birden fazla arayüz kullanmalıyız");


            System.Console.WriteLine("D- Dependency Inversion");
            System.Console.WriteLine("Sınıflar arası bağımlılıklar olabildiğince az olmalıdır. Özeliikle üst seviye sınıflar alt seviye sınıflara bağımlı olmamalıdır.");

            

        }
    }
}
