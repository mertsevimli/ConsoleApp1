namespace KalitimInheritance
{
    interface OrnekArayuz
    {
        public int Id { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Interfacesi Arayüzler!");
            System.Console.WriteLine("Bir Tv kumandasının tuşları gibi classları dizays edebilmenizi sağlayan yapılardır.");
            System.Console.WriteLine("Classlara benzer tanımlanırlar");
            System.Console.WriteLine("Bir class a bir interface den kalıtım alırınırsa ilgili interface içerisindeki tüm özellikler class da kullanılmak zorundadır.!");
        }

    }

    interface ISinifGereksinimleri // interface lere isim verirken İlk harf I yapılmalıdır
    {
        // bu interface bir sınıfta kalıtım alınırsa aşağıdaki tüm propertyler kullanılmak zorundadır.
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
    interface IVeritabaniIslemleri
    {

        // bu interface bir sınıfta kalıtım alınırsa aşağıdaki tüm methodlar kullanmak zorundadır.
        // interface lerde methodlar sadece aşağıdaki gibi tanımlanır! Methodun yapacağı iş burada değil kullanılacağı  classta yapılır!
        void Add(); // kayıt ekleme metot imzası
        void Update();// güncelleme
        void Delete();// Sil
        void GetAll(); // Listele
    }
    class Urun : ISinifGereksinimleri, IVeritabaniIslemleri // bu şekilde ürün sınıfında ISinifGereksinimleri interfacinden kalıtım alırsak interface içindeki tüm proplar burada da yeniden tanımlanmak zorundadır.
    {
        // ampulden implement interface e basarsanız otomatik  gelir doldurur. !!!!!!
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public string? Resim { get; set; }
        public decimal Fiyati { get; set; }
        public int Kdv { get; set; }
        public string? Acıklamasi { get; set; }

        public void Add()
        {
            System.Console.WriteLine("Ürün Eklendi");
        }

        public void Delete()
        {
            System.Console.WriteLine("Ürün Silindi");
        }

        public void GetAll()
        {
            System.Console.WriteLine("Ürün Listelendi");
        }

        public void Update()
        {
            System.Console.WriteLine("Ürün Güncellendi.");
        }
    }
}

