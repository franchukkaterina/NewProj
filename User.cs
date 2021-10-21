public class User
{
    public string Login { get; set; }
    
    public string Parole { get; set; }
    
    
    
    public User(string login, string parole, int age){
        this.Login=login;
        this.Parole=parole;
        this.Age=age;
    }

    public override string ToString()
    {
        return $"User: {this.Login}, Parole: {this.Parole}, Age user: {this.Age}";
    }


}