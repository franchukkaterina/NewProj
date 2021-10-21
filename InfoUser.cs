public class InfoUser : User
{
    public int Age { get; set; }
    public string Name { get; set; }
    
    public string Lastname { get; set; }
    
    public string Middlname { get; set; }
    
    public InfoUser(int age, string name, string lastname, string middlname){
        this.Age=age;
        this.Name=name;
        this.Lastname=lastname;
        this.Middlname=middlname; 
    }


    public override string ToString()
    {
        return base.ToString + $", Age user: {this.Age}, Full Name User is: {this.Name} {this.LastName} {this.Middlname}";
    }
}