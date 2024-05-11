using System.ComponentModel;
using Konu12KalitimInheritance;

namespace KalitimInheritance
{
    class Arac
    {
        public string AracTuru;
        public void KornaCal()
        {
            System.Console.WriteLine(AracTuru + " kornasına basıldı!");
        }
        class Otomobil : Arac//Otomobil classına  Arac classından miras aldık
        {
            public string Marka { get; set; }
            public string Model { get; set; }

        }
        class Tren
        {
            public int TrenNo { get; set; }
            public int VagonSayisi { get; set; }
        }
        class Vapur : Arac
        {
            public string GemiAdi { get; set; }
            public int GemiNo { get; set; }
        }

        internal class Program
        {
            static void Main(string[] args)

            {

                System.Console.WriteLine("Kalıtım Inheritance!");
                System.Console.WriteLine("Sınıflarda bir class taki method property, değişken vb gibi özellikleri bir başka class a devredebilme özelliği vardır.Böylece ortak nesneleri bir sınıfa koyup oradan alacağımız kalıtım ile alt sınıflarda aynı nesneleri tekrar yazmaktan kurtuluruz.");
                #region KalıtımKodBölgesi
                // Bu şekilde  kodlarımızı yaptığı işe göre bloklara ayırabiliyoruz.      

                Arac arac = new Arac();
                arac.AracTuru = String.Empty;
                arac.KornaCal();


                Otomobil otomobil = new Otomobil();
                otomobil.Marka = "TOGG";
                otomobil.AracTuru = otomobil.Marka + " SUV"; //  AracTuru de arac sınıfından gelir
                otomobil.KornaCal(); // Burakadaki KornaCal metodu Arac sınıfından  gelir.
                Tren tren = new Tren();
                tren.TrenNo = 001;
                tren.VagonSayisi = 9;
                // tren.KornaCal(); treni arac sınıfından kalıtmazsak bu metoda ulaşamayız

                System.Console.WriteLine();

                Vapur vapur = new Vapur()
                {
                    AracTuru = " Vapur",
                    GemiAdi = " Paşabahçe",
                    GemiNo = 18
                };
                System.Console.WriteLine($"Vapur Bilgileri : Gemi No : {vapur.GemiNo} ");
                System.Console.WriteLine("Gemi Adı : " + vapur.GemiAdi);
                vapur.KornaCal();// Vapuru da arac sınıfından miras aldırdığımız için metodu kullanabiliyoruz.

                System.Console.WriteLine();


                Kategori kategori = new Kategori();
                kategori.Name = "Telefon";
                kategori.Acıklamasi = " Kıpraşmalı";
                kategori.CreateDate = DateTime.Now;
                System.Console.WriteLine("Kategori : " + kategori.Name);

                System.Console.WriteLine();

                Marka marka = new Marka()
                {
                    Name = "Samsung",
                    IsActive = true,
                    Logo = "/Resimler/samsung.png"
                };
                System.Console.WriteLine("Marka : " + marka.Name);

                System.Console.WriteLine();

                Urun urun = new Urun()
                {
                    Id = 1,
                    Name = "S18 Telefon",
                    Fiyati = 18800,
                    Kdv = 20,

                    IsActive = true, // ürün pasife çekilmiş mi yoksa aktif mi
                    Acıklamasi = "Samsun galaksi es 18"
                };
                if (urun.IsActive == true && urun.IsDelete == false)// eğer ürün silinmemiş ive kullanıma acıksa
                {
                    System.Console.WriteLine("Ürün Detayı");
                    System.Console.WriteLine("Ürün Adı : " + urun.Name);
                    System.Console.WriteLine("Ürün Açıklaması : " + urun.Acıklamasi);

                }
                #endregion


                #region  PolimorpizmOrnekleri

                Cizici cizici = new Cizici(); 
                //cizici.Ciz();
                Cizici [] birCizici = new Cizici[4];// 4 elemanlı bir dizi
                birCizici[0] = new Cizici();// her bir elemanı ayrı classtan
                birCizici[1] = new DogruCiz();
                birCizici[2] = new DaireCiz();
                birCizici[3] = new Kareciz();
                foreach (var item in birCizici)  // dizi verilerinde foreach kullanıyoruz.
                {
                    item.Ciz(); // dizideki her nesnenin içindeki ciz metodunu çalıştır.


                }
                
                




                #endregion


            }


        }
        // Polimorpizm-çokbiçimcilik
        // Bir metodun ezilerek farklı çıktılar üretebilmesini sağlama yöntemi
        internal class Cizici
        {
            public virtual void Ciz()// normal void bir metoda ekstra virtual ifadesi ekledik, böylece bu metot farklı yerlerde ezilebilir ve farklı çıktılar üretebilir hale geldi.
            {
                System.Console.WriteLine("Ciz metodu çalıştı"); // Ciz metodu normalde ekrana bu çıktıyı veriyor.

            }

        }
        internal class DogruCiz : Cizici
        {
            public override void Ciz()
            {
                System.Console.WriteLine("DogruCiz metodu Çalıştı");
            }
        }
    internal class DaireCiz : Cizici
        {
            public override void Ciz()
            {
                System.Console.WriteLine("DaireCiz metodu Çalıştı");
            }
        }
            internal class Kareciz : Cizici
        {
            public override void Ciz()
            {
                System.Console.WriteLine("Kareciz metodu Çalıştı");
            }
        }
    }


}
