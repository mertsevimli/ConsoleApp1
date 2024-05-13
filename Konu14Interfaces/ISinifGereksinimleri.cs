namespace Konu14Interfaces;

interface ISinifGereksinimleri // interface lere isim verirken İlk harf I yapılmalıdır
    {
        // bu interface bir sınıfta kalıtım alınırsa aşağıdaki tüm propertyler kullanılmak zorundadır.
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }

