public class User
{
    public string Login { get; set; }
    
    public string Parole { get; set; }
    
    public string Email { get; set; }
    
    
    
    public User(string login, string parole, string email){
        this.Login=login;
        this.Parole=parole;
        this.Email=email;
    }

    public override string ToString()
    {
        return $"User: {this.Login}, Parole: {this.Parole}, Email is {this.Email}";
    }


}