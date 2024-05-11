internal class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Kapsülleme - Encapsulation!");
        System.Console.WriteLine(" Gerçek hayatta dışında kapsül içinde toz ilaç olan yapılara benzer bir sistemin yazılıma uyarlanmış halidir.");
        System.Console.WriteLine("Hassas veri kullanıp bu veriye dışarıdan istemediğimiz şekilde ulaşabilmesini önlememizi sağlar.");

        System.Console.WriteLine();

        Bolum bolum = new Bolum();
        System.Console.WriteLine("Kayıt Yaptırmak İstediğiniz Bölümü Yazınız:");
        var girilenBolum = Console.ReadLine();
        var numara = 18;
        var durum = true;
        bolum.SetBolumAdi(girilenBolum);
        var sonuc = bolum.GetBolumAdi();
        //Y System.Console.WriteLine(sonuc);

        Fakulte fakulte= new Fakulte();
        fakulte.Bolum = girilenBolum;


    }
    // Method Kullanarak Kapsülleme
    public class Bolum
    {
        private string BolumAdi;// sadece classtan erişebileceğimiz gizli değişkenimiz
        // Accesor - Getter
        public string GetBolumAdi() // BolumAdi değişkenindeki veriyi dışarı göndermemizi sağlayan public metodumuz
        {
            return BolumAdi;// geriye private değişken verisini gönderiyoruz.
        }
        // Mutator - Setter 
        public void SetBolumAdi(string a) // private string BolumAdi; na bu metotla kontrollü şekilde değer ataması yaptırıyoruz.!
        {
            if (a == "Yazılım") // burası kapsülleme işleminin yapıldığı yer. Eğer istemediğin bir veri gelmişsse bu blok çalışmayacak
            {
                BolumAdi = a;// eğer a parametresine gönderilen değer Yazılıma eşitse private BolumAdi değişkenine atamaya izin ver
                System.Console.WriteLine(a + " Eğitimi Başvurunuz Alınmıştır.");
            }
            // burada program ihtiyacına göre  else if lerle kontroller çoğaltılabilir.
            else
            {
                System.Console.WriteLine(a + " Eğitimi Kurumuzda Verilmektedir!");
            }

        }
    }

    public class Fakulte
    {
        public int MyProperty { get; set; } // bu property açıp aşağıdaki gibi kullanabiliyoruz. Propertynin değişkenden en önemli farklarından birisi bu 
        private string bolum;
        public string Bolum
        {

            get
            {
                return bolum;
            }
            set
            {
                if (value == "Yazılım" || value == "yazılım")// eğer gönderilen değer yazılıma eşitse
                {
                    bolum = value; // içeride kapsüllediğimiz bölüm değişkenine değeri ata
                    System.Console.WriteLine("Kurumumuzda " + value + " Eğitimine Başvurunuz Alındı!");
                }
                else
                {
                    System.Console.WriteLine("Kurumumuzda " + value + " Eğitimi Verilmemektedir.");
                }
                return;
            }
        }
    }



}
