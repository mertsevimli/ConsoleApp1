namespace Konu07Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Döngüler!");
            System.Console.WriteLine("1-For Döngüsü");
            for (int i = 1; i <= 10; i++)  //  döngü tanımlama 3 bloktan oluşuyor.
            // int i = 0;  bildiğimiz değişken tanımlama. 
            //i < 10 ; i nin değeri 10 sayısından küçük olduğu sürece dönmeye devam et.
            // i++ : her döndüğünde i nin değerini 1 artır ki sonsuz döngü olsun
            {
                System.Console.WriteLine("i nin değeri : " + i);
            }
            System.Console.WriteLine();
        }
    }
}
