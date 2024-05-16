using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Specialized;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Xml;

namespace Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Liste kullanarak user classını kullanma");
            myworkspace();
        }
        static void myworkspace()
        {
            
            System.Console.WriteLine();

            List<User> users = new();
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
                System.Console.WriteLine($"Kullanıcı Bilgileri :  Adı : {item.Name} Email {item.Email}");
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
            foreach (var item in kullanicilar)
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
                Id = 6,
                Name = "Lider",
                Email = "lider@liderpide.net",
                Password = "Lid159"
            };

        }

    }
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Old { get; set; }
    }
}