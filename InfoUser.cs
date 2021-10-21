public class InfoUser : User
{
    public int Age { get; set; }
    public string Name { get; set; }
    
    public string Lastname { get; set; }
    
    public string Middlname { get; set; }
    
    public InfoUser(int age, string name, string lastname, string middlname){
        this.Age=age;
        this.Lastname=lastname;
        this.Middlname=middlname;
        
    }
}