public class User
{
    public string Username { get; set; }
    public string Password { get; set; }

    public User(string username, string password)
    {
        Username = username;
        Password = password;
    }

    public override bool Equals(object obj)
    {
        return obj is User user &&
               Username == user.Username &&
               Password == user.Password;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Username, Password);
    }
}

/* 
	Program.cs ve User.cs 
	Bunlarin uzerinden gidebilirsin.
*/ 