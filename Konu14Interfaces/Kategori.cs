
namespace Konu14Interfaces;

internal class Kategori : ISinifGereksinimleri , IVeritabaniIslemleri
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime UpdateDate { get; set; }

    public string? Desciption { get; set; }
    public string? KategoriBanner { get; set; }
    public bool UstMenudeGoster  { get; set; }

    public void Add()
    {
        System.Console.WriteLine("Kategori Eklendi");
    }

    public void Delete()
    {
        System.Console.WriteLine("Kategori Silindi");
    }

    public void GetAll()
    {
        System.Console.WriteLine("Kategoriler Listelendi");
    }

    public void Update()
    {
        System.Console.WriteLine("Kategori Güncellendi");
    }
}
