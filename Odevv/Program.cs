using System;
using System.Collections.Generic;

class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string FullName { get; set; }
}


class Program
{
    static void Main(string[] args)
    {
        List<User> users = new List<User>();


        users.Add(new User
        {
            Username = "user1",
            Password = "pass1",
            FullName = "Mert Sevimli "
        });
        users.Add(new User
        {
            Username = "user2",
            Password = "pass2",
            FullName = "Beyza Aktaş"
        });
        users.Add(new User
        {
            Username = "user3",
            Password = "pass3",
            FullName = "Semih Sinan"
        });
        users.Add(new User 
        {
            Username = "Şimşek",
            Password = "Queen",
            FullName = " Şimşek Queen"
        });
        {

        }

        Console.WriteLine("Kullanıcı Adı:");
        string username = Console.ReadLine();

        Console.WriteLine("Şifre:");
        string password = Console.ReadLine();

        // Yeni kullanıcı oluştur
        User newUser = new User { Username = username, Password = password };

        // Kullanıcıyı listede ara
        bool userFound = false;
        foreach (User user in users)
        {
            if (user.Username == newUser.Username && user.Password == newUser.Password)
            {
                userFound = true;
                Console.WriteLine($"Hoş geldin, {user.FullName}!");
                break;
            }
        }

        if (!userFound)
        {
            Console.WriteLine("Kullanıcı bulunamadı.");
        }

        Console.ReadLine();
    }
}


/*

 Nasil goruntuluyorsun app'de
  Terminalde görüyorum sadece 
  Wpden attım abi 

 */