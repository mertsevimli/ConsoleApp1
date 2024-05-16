using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<User> userList = new List<User>
        {
            new User("Alice", "password123"),
            new User("Bob", "qwerty"),
            new User("Charlie", "abc123")
        };

        Console.Write("Kullanıcı adınızı girin: ");
        string username = Console.ReadLine();

        Console.Write("Şifrenizi girin: ");
        string password = Console.ReadLine();

        User newUser = new User(username, password);

        if (userList.Contains(newUser))
        {
            Console.WriteLine($"Hoş geldin {username}");
        }
        else
        {
            Console.WriteLine("Kullanıcı bulunamadı");
        }
    }
}
