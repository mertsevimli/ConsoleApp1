namespace Konu14Interfaces;


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
