public class InfoUser : User
{
    public int Age { get; set; }
    public string Name { get; set; }
    
    public string Lastname { get; set; }
    
    public string Middlname { get; set; }
    
    public InfoUser(string login, string parole, string email ,int age, string name, string lastname, string middlname) : base(login, parole, email){
        this.Age=age;
        this.Name=name;
        this.Lastname=lastname;
        this.Middlname=middlname; 
    }


    public override bool Equals(object obj)
    {
        if(obj is InfoUser)
        {
            InfoUser u = obj as InfoUser;
            if(u.Login != this.Login) return false;
            if(u.Parole != this.Parole) return false;
            if(u.Email != this.Email) return false;
            if(u.Age != this.Age) return false;
            if(u.Name != this.Name) return false;
            if(u.Lastname != this.Lastname) return false;
            if(u.Middlname != this.Middlname) return false;
            return true;
        }  
        return false;
    }

    public override int GetHashCode()
    {
        return (this.Name.GetHashCode() + this.Lastname.GetHashCode() + this.Middlname.GetHashCode());
    }

    public override string ToString()
    {
        return $"Age user: {this.Age}, Full Name User is: {this.Name} {this.Lastname} {this.Middlname}";
    }
}