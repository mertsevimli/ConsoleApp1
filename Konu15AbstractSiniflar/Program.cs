namespace Konu15AbstractSiniflar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Abstract Sınıflar!");
            System.Console.WriteLine(" Abstract classlar hem class hemde interface özelliklerine sahip yapılardır.");
            System.Console.WriteLine("Dolayısıyla içinde hem metot imzası hem de metot tanımlayabiliriz");
            System.Console.WriteLine("Classlarda metot imzası tanımlayamayız ama metot tanımlayabiliriz.");
            System.Console.WriteLine("Interface lerde metot imzası tanımlayabiliriz ama metot tanımlayamayız");
            System.Console.WriteLine("Sınıflarda new ile nesleler oluşturabiliriz fakat abstract sınıflar sadece kalıtım amaçlı geliştirdiği için new ile nesne oluşturamazlar.");
            System.Console.WriteLine("Bir sınıfa sadece 1 tane abstract sınıf inherit edilebilir fakat bir sınıfa birden fazla interface  inherit edilebilir( yabş 1 sınıf birden fazla interface den kalıtıma alabilir.)");

            System.Console.WriteLine();

            // abstract class tan nesne oluşturma
            //Database database= new Database();// abstract bu şekilde direkt nesne oluşturmaya izin vermez !
            System.Console.WriteLine("Sql veritabanı işlemleri");
            Database database= new SqlServer(); // abstract classlarda nesneyi bu şekilde oluşturabiliriz!
            database.Add();
            database.Update(18); // methodu id ile  çalışır yaptığımız için güncellemek istediğimiz kayıt  numarasını bu şekilde parametra  olarak yollamak zorundayız yoksa hata alırız.!


            System.Console.WriteLine("MySql Data İşlemleri");

            Database database2 = new MySql();
            database2.Add();
            database2.Delete(18);

        }
    }
    abstract class Database
    {
        public void Add() // class lardaki gibi normal method ekleme
        {
            System.Console.WriteLine("Ekleme metodu çalıştı");
        }
        public abstract void Delete(int id); // abstract class ta interface gibi method imzası tanımlama
        public abstract void Update(int id);
        public abstract void Get(int id);
    }
    class SqlServer : Database // SqlServer veritabanı kayıt işlemleri yapan bir sınıftır ve ana database sınıfındaki method imzalarına ait metotları kullanmak zorundadır.
    {
        public override void Delete(int id)
        {
            System.Console.WriteLine("SqlServer dan " + id + " numaralı kayıt silindi!");
        }

        public override void Get(int id)
        {
            System.Console.WriteLine("SqlServer dan " + id + " numaralı kayıt getirildi!");
        }

        public override void Update(int id)
        {
            System.Console.WriteLine("SqlServer dan " + id + " numaralı kayıt güncellendi!");
        }
    }
    class MySql : Database
    {
        public override void Delete(int id)
        {
            System.Console.WriteLine("MySql dan " + id + " numaralı kayıt silindi!");
        }

        public override void Get(int id)
        {
            System.Console.WriteLine("MySql dan " + id + " numaralı kayıt getirildi!");
        }

        public override void Update(int id)
        {
            System.Console.WriteLine("MySql dan " + id + " numaralı kayıt güncellendi!");
        }
    }
}