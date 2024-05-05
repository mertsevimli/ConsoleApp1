namespace StructYapilar
{
    public struct Yapi
    {
        public int sayi;
        public string metin;
        public void Metot()
        {
            System.Console.WriteLine("yapı içindeki metot çalıştı");
        }
    }
    internal class Program
    {
        struct Kimlik
        {
            public string Ad;
            public string Soyad;
            public int Yas;
            public string DogumYeri;
            public struct Adres
            {
                public int Id { get; set; }
                public string Sehir { get; set; }
                public string Mahalle { get; set; }
                public string AcikAdres { get; set; }
            }
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Struct Yapılar!");
            System.Console.WriteLine("Yapılar sınıflara benzer, sınıfların nesneleri bellekte heap alaınında tutulurken yapılarındaki stack alanında tutulur");
            System.Console.WriteLine("C# ta değişkenler referans ve diğer tipli olarak ikiye ayrılır");
            System.Console.WriteLine("Stack bölgesinde tutulan veriler değer tiplilerdir( String dışındaki veri tipleri ve bu struct nesneleri) ve işleri bittiğinde bellekten hemen atılırlar.");
            System.Console.WriteLine("Heap bölgesinde tutulan veriler referans tiplilerdir ( string ve class nesneleri )ve işleri bittiğinde bellekten hemen atılmazlar GC( garbage collector) yapısıyla bir süre sonra silinirler. ");

            System.Console.WriteLine();
            Yapi yapi = new Yapi();
            yapi.Metot();
            yapi.metin = "yapı metni";
            yapi.sayi = 18;
            System.Console.WriteLine("yapi.metin = " + yapi.metin);
            System.Console.WriteLine("yapi.sayi = " + yapi.sayi);
            System.Console.WriteLine();

            Kimlik kimlik = new Kimlik();
            kimlik.Ad = "Beyza";
            kimlik.Soyad = "Erdem";
            kimlik.Yas = 18;
            System.Console.WriteLine($"Kimlik Bilgileri:\nAd Soyad: {kimlik.Ad} {kimlik.Soyad} ");
            System.Console.WriteLine("Yaş : " + kimlik.Yas);

            System.Console.WriteLine("Kişiye Ait Adres Bilgileri :");
            Kimlik.Adres adres1 = new Kimlik.Adres
            {
                Sehir = "Karabük"
            };
            Kimlik.Adres adres = adres1;// kimlik nesnesinin içindeki adres nesnesine bu şekilde erişiyoruz.
            adres.Sehir = "Çukurambar mah.";

            System.Console.WriteLine(adres.Sehir + "" + adres.Mahalle);



        }
    }

}