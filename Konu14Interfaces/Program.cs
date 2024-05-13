using System.Data.Common;
using Konu14Interfaces;

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


            System.Console.WriteLine(" Sisteme kaydetmek istediğiniz marka adını giriniz");
            System.Console.WriteLine();
            var markaAdi = Console.ReadLine();
            Marka marka = new Marka()
            {
                Name = markaAdi,
                Id = 1,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now,
            };
            marka.Add();
            System.Console.WriteLine();
            marka.Ekle(marka);// ekle metodu bizden parametre olarak bir marka bekler
        }

    }
}

