namespace Konu12KalitimInheritance;


internal class Urun : OrtakOzellikler // Bu şekilde OrtakOzellikker classındaki tüm propertyler Urun clasındaymış gibi kullanılabilir. Urun sınıfından nesne oluşturağımız yerde

{
    public string? Resim {get; set; }    
    public decimal Fiyati { get; set; }
    public int Kdv { get; set; }
    public string? Acıklamasi { get; set; }
}


