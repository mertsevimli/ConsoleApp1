using System.ComponentModel;

namespace Enumlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enumlar!");
            System.Console.WriteLine("Projelerimizde sabit olan ve proje genelinde kullanabileceğimiz nesnelerdir. Projeye giriş yapan yönetici rolü,sipariş durumu vb gibi genel kullanımlarda işe yarar.");
            System.Console.WriteLine();
            byte a = (byte)Meyveler.Armut;
            byte b = (byte)Meyveler.Elma;
            byte c = (byte)Meyveler.Çilek;
            System.Console.WriteLine("Meyveler.Armut: " + Meyveler.Armut);
            System.Console.WriteLine("Meyveler.Armut(a): " + a);
            System.Console.WriteLine("Meyveler.Çilek: " + Meyveler.Çilek);
            System.Console.WriteLine("Meyveler.Armut(c): " + c);
            SiparisKontrol(2);
            System.Console.WriteLine();
            SiparisKontrol2(4);

            System.Console.WriteLine();
            System.Console.WriteLine(UserType.SuperAdmin);
            System.Console.WriteLine();

        }

        enum Aylar : byte // aylar byte veri tipinde numaralansın
        {

            Ocak, Şubat, Mart
        }
        enum SiparişDurumu

        {
            Hazırlanıyor, Hazırlandı, KargoBekleniyor, Kargolandı, TeslimEdildi
        }

        enum Meyveler : int // Meyveler int veri tipinde numaralansın
        {
            Elma = 3, Armut = 7, Çilek = 1
        }
        static void SiparisKontrol(int siparisDurumu)
        {
            if (siparisDurumu == (int)SiparişDurumu.Hazırlanıyor)
            {
                System.Console.WriteLine("Sipariş Durumu: " + SiparişDurumu.Hazırlanıyor);
            }

            if (siparisDurumu == (int)SiparişDurumu.Hazırlandı)
            {
                System.Console.WriteLine("Sipariş Durumu: " + SiparişDurumu.Hazırlandı);

            }
            if (siparisDurumu == (int)SiparişDurumu.KargoBekleniyor)
            {
                System.Console.WriteLine("Sipariş Durumu: " + SiparişDurumu.KargoBekleniyor);
            }

            if (siparisDurumu == (int)SiparişDurumu.Kargolandı)
            {
                System.Console.WriteLine("Sipariş Durumu: " + SiparişDurumu.Kargolandı);

            }

            if (siparisDurumu == (int)SiparişDurumu.TeslimEdildi)
            {
                System.Console.WriteLine("Sipariş Durumu: " + SiparişDurumu.TeslimEdildi);
            }
        }
        static void SiparisKontrol2(int siparisDurumu)

        {
            switch (siparisDurumu)

            {
                case (int)SiparişDurumu.Hazırlanıyor:
                System.Console.WriteLine("Sipariş Durumu: Hazırlanıyor!");
                    break;
                    case (int)SiparişDurumu.Hazırlandı:
                System.Console.WriteLine("Sipariş Durumu: Hazırlandı!");
                    break;
                    case (int)SiparişDurumu.KargoBekleniyor:
                System.Console.WriteLine("Sipariş Durumu: Kargo Bekleniyor!");
                    break;
                    case (int)SiparişDurumu.Kargolandı:
                System.Console.WriteLine("Sipariş Durumu: Kargolandı!");
                    break;
                    case (int)SiparişDurumu.TeslimEdildi:
                System.Console.WriteLine("Sipariş Durumu: Teslim Edildi!");
                    break;
                default:
                    System.Console.WriteLine("Bilinmiyor!");
                    break;
            }
                    }
    public enum UserType
    {
        [Description("Süper Admin")]
        SuperAdmin = 1,
        [Description("İş Veren")]
        Employer,
        [Description("Çalışan")]
        employee
    }
    
    }


}
