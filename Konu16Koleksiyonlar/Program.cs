using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Specialized;
using System.Runtime.CompilerServices; // koleksiyonlar bu kütüphane altında yer alır. Bunu tanımlamazsak koleksiyonları kullanamayız hata verir.!

namespace Konu16Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Collections , Koleksiyonlar ");
            System.Console.WriteLine("Farklı veri tipleriyle dizilere benzer şekilde listelere veri ekleyip bunları tutmamıza yardımcı olan ve dizilerden cok daha fazla özelliğe sahip olan yapılardır.");
            System.Console.WriteLine();

            // Ornek1(); // ArrayList
            //Ornek2();// ArrayList
            //Ornek3();// ArrayList
            //Ornek4(); // stringcollection
            //Ornek5(); // StringDictionary
            //Ornek6(); // Stack
            //Ornek7(); // Queue 
            //Ornek8(); // dictionary
            Ornek9();// List en çok kullanımı bunu kullanırız.
        }
        static void Ornek1() // array List
        {
            ArrayList arrayList = new ArrayList();// diziden farklı olarak hangi tipte veriden oluşacağını belirtmeyiz
            arrayList.Add(1);// arrayList object tipinde veri alır , yani tüm veri tiplerini
            arrayList.Add(2);  // dizilerde add metodu yoktur sonradan kayıt eklenmez
            arrayList.Add(3);
            System.Console.WriteLine("Arraylist deki ilk eleman : " + arrayList[0]);
            foreach (int i in arrayList)
            {
                System.Console.WriteLine(i);
            }
        }

        static void Ornek2()

        {
            System.Console.WriteLine("ArrayList");
            ArrayList arrayList = new ArrayList();
            arrayList.Add("İstanbul");
            arrayList.Add("Ankara");
            arrayList.Add("İzmir");
            arrayList.Add("Karabük");
            arrayList.Add("Çankırı");
            foreach (var item in arrayList)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("ArrayListeki ilk eleman : " + arrayList[0]);
            System.Console.WriteLine();
            System.Console.WriteLine("Arraylist de  short () sıralama yapabiliriz.");

            arrayList.Sort(); // Listeyi sıraladık
            System.Console.WriteLine("Sıralanmış ArrayList Şehir Listesi");
            foreach (var item in arrayList)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine();
            arrayList.Reverse();// Tersten sıralama metodu

            System.Console.WriteLine("Tersten sıralanmış ArrayList Şehir Listesi");
            foreach (var item in arrayList)
            {
                System.Console.WriteLine(item);

            }
            System.Console.WriteLine();
        }
        static void Ornek3()
        {
            System.Console.WriteLine("ArrayListe e farklı veri tipiyle karışık liste yapabiliriz.");
            ArrayList arrayList = new ArrayList();
            int tamsayi = 18;
            double kesirlisayi = 17.25;
            arrayList.Add(tamsayi);
            arrayList.Add(kesirlisayi);
            arrayList.Add("Ankara");
            foreach (var item in arrayList)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine();
            System.Console.WriteLine("For Döngüsü Kullanımı : ");
            for (int i = 0; i < arrayList.Count; i++)
            {
                System.Console.WriteLine(arrayList[i]); // i index no , değeri kaçsa onu yazdır.
            }
        }
        static void Ornek4()
        {
            System.Console.WriteLine("Sadece stringten oluşan liste");
            StringCollection stringListesi = new StringCollection();
            //stringListesi.Add(18); // bu tipe string dışında veri eklenemez
            stringListesi.Add("Ankara");
            stringListesi.Add("Merkez");
            stringListesi.Add("");
            stringListesi.Add("İstanbul");
            foreach (string item in stringListesi)
            {
                System.Console.WriteLine(item);
            }
        }

        static void Ornek5()
        {
            System.Console.WriteLine("StringDictionary : Key - Value şeklinde bir satırda 2 değer kullanabilmemizi sağlar");
            StringDictionary dictionary = new StringDictionary();
            dictionary.Add("01", "Adana"); // 1. değer Key (anahtar,) 2. değer value ( değer)
            dictionary.Add("06", "Angara");
            dictionary.Add("78", "Karabük");
            dictionary.Add("18", "Çankırı");
            dictionary.Add("34", "İstanbul");
            System.Console.WriteLine("Listedeki değerleri (Values) ekrana yaz :  ");
            foreach (var item in dictionary.Values)
            {
                System.Console.WriteLine(item);
            } // 
            System.Console.WriteLine("Listedeki anahtarları (Keys)ekrana yaz : ");
            foreach (var item in dictionary.Keys)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("Liste satırını ekrana yaz : ");
            foreach (var item in dictionary)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("34 değerine sahip eleman : " + dictionary["34"]);
        }

        static void Ornek6()
        {
            System.Console.WriteLine("Stack Kullanımı");
            System.Console.WriteLine("Stack Sınıfı programlamada LIFO (Last in first out) kuyruğa son giren ilk çıkar mantığıyla çalışır.");
            Stack stack = new Stack();
            // stack.Add();// Stack yapısında listeye ekleme add ile olmaz
            stack.Push("İstanbul");// object olarak her türlü veriyi kabul eder.
            stack.Push(34);
            stack.Push(99.90);
            while (stack.Count > 0)
            {
                System.Console.WriteLine(stack.Pop());// stack yığın şeklinde çalışır ve nesneler üst üste konmuş mantığında dizilir. Pop metodu en üstten başlayarak elemanları çeker getirir.
            }
        }

        static void Ornek7()
        {
            System.Console.WriteLine("Queue Kullanımı");
            System.Console.WriteLine("Queue sınıfı programlamada FIFO (First in First out) ilk giren ilk çıkar mantığı ile çalışır.");
            Queue queue = new Queue();
            queue.Enqueue("1");
            queue.Enqueue("Angara");
            queue.Enqueue("3");
            while (queue.Count > 0)
            {
                System.Console.WriteLine(queue.Dequeue());//Listeden öğeleri çekmek için Dequeue metodu kullanılır.
            }
        }

        static void Ornek8()
        {
            System.Console.WriteLine("Dictionary");
            System.Console.WriteLine("Bu yapıyla key ve value tiplerini bizim belirleyeceğimiz listeler oluşturabiliriz.");
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("34", "İstanbul");
            dictionary.Add("06", "Ankara");
            System.Console.WriteLine("book : " + dictionary["book"]);// key değerini vererek value ya ulaşabiliriz.
            System.Console.WriteLine("dictionary.Keys");
            foreach (var item in dictionary.Keys)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("dictionary.Values : ");
            foreach (var item in dictionary.Values)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine();
            Dictionary<int, string> dictionary2 = new Dictionary<int, string>();// key olarak int , value olarak strin verisi tutabileceğimiz bir liste oluşturduk.
            dictionary2.Add(01, " Adana");
            dictionary2.Add(34, " İstanbul");
            dictionary2.Add(06, " Ankara");
            foreach (var item in dictionary2)
            {
                System.Console.WriteLine(item.Key);
            }
            System.Console.WriteLine();
            foreach (var item in dictionary2)
            {
                System.Console.WriteLine(item.Value);

            }
            System.Console.WriteLine();
            foreach (var item in dictionary2)
            {
                System.Console.WriteLine(item.Key + "" + item.Value);// Listedeki key ve value yi aynı anda yazdık
            }

        }

        static void Ornek9()
        {
            System.Console.WriteLine("Liste Kullanımı"); //List bize tanımlamış olduğumuz veri tipinde listeler oluşturmamızı sağlar
            List<string> sehirler = new(); // Listenin bir string listesi olucağını belirttiğimiz için strin veri ekleyebiliyoruzç
            sehirler.Add("İstanbul");
            sehirler.Add("Ankara");
            sehirler.Add("İzmir");
            //sehirler.Add(18); // string listesine harici tipte veri eklenmez !
            foreach (var item in sehirler)
            {
                System.Console.WriteLine(item); // listedeki her bir şehri ekrana yazdır.
            }
            System.Console.WriteLine();

            List<User> users = new();// boş bir user listesi oluştur.
            users.Add(new User()
            {
                Email = "mert234tr@gmail.com",
                Id = 007,
                Name = "Mert",
                Password = "Lebron23456"
            });
            users.Add(new User()
            {
                Email = "alp@aslan.net",
                Id = 02,
                Name = "Murat Yılmaz",
                Password = "Thug123"
            });
            System.Console.WriteLine("Listedeki Kullanıcılar : ");
            foreach (var item in users)
            {
                System.Console.WriteLine($"Kullanıcı Bilgileri :  Adı : {item.Email} Email {item.Email}");
            }
            List<User> kullanicilar = new()
            {
                new User()
                {
                    Id = 3,
                    Name = "Mert",
                    Password = "M126"
                },
                 new User()
                 {
                     Id = 18,
                     Name = "Nisa",
                     Password = "Nisa147",
                     Email = "naz@gmail.com"
                 }
            };
            System.Console.WriteLine("Kullacilar Listesi : ");
            foreach(var item in kullanicilar)
            {
                System.Console.WriteLine($"Kullanıcı Bilgileri : No : {item.Id} Adı : {item.Name} Email {item.Email}");
            }
            System.Console.WriteLine();
             users.AddRange(kullanicilar); // kullanicilar listesini users listesine topluca ekler  AddRange kodu ekler

             System.Console.WriteLine("2 listenin birleşimi sonrası dögü : ");
             foreach (User item in users)
             {
                System.Console.WriteLine($"Kullanıcı Bilgileri : No : {item.Id} Adı : {item.Name} Email {item.Email}");
             }
             var yeniKullanici = new User()
             {
                Id = 6, Name = "Lider" , Email = "lider@liderpide.net" , Password ="Lid159"
             };
             System.Console.WriteLine("Kullanıcı Listesinde yeniKullanici var mı?");
             System.Console.WriteLine(users.Contains(yeniKullanici));//Contains metodu yeniKullanici nesnesini users içinde arar bulursa true bulamazsa false döner.
             users.Add(yeniKullanici); // users listesine yenikullanici yı ekledik
             System.Console.WriteLine("Şimdi var mı?");
             System.Console.WriteLine(users.Contains(yeniKullanici));
        }



    }
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}