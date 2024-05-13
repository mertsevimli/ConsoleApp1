
namespace Konu14Interfaces;

internal class Marka : ISinifGereksinimleri, IVeritabaniIslemleri  // Marka :  iki nokta üst üste diye koyup yapıyoruz. Daha sonra aralarına virgül koyacaksın !!!
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime UpdateDate { get; set; }
    public void Ekle(Marka marka)
    {
        if (marka != null) // marka null değilse  bu işareti yapıyoruz !=
        {
            System.Console.WriteLine("Marka Eklendi!");
            System.Console.WriteLine("Eklenen Marka Bilgileri : ");
            System.Console.WriteLine("Adı : " + marka.Name);
            System.Console.WriteLine("No : " + marka.Id);
            System.Console.WriteLine("Eklenme Tarihi : " + marka.CreateDate);
            System.Console.WriteLine("Son Güncelleme Tarihi :  " + marka.Update);
        }
        else

            System.Console.WriteLine("Marka Eklenemedi !");

    }
    public void Add()
    {
        System.Console.WriteLine("Marka Eklendi");
    }

    public void Delete()
    {
        System.Console.WriteLine("Marka Silindi");
    }

    public void GetAll()
    {
        System.Console.WriteLine("Marka Listelendi");
    }

    public void Update()
    {
        System.Console.WriteLine("Marka Güncellendi");
    }
}


