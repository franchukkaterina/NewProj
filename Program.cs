using System;
using System.Collections.Generic;
using System.Linq;


namespace NewProj
{
    class Program
    {
        static void Main(string[] args)
        {
            MySystem<InfoUser> list = new MySystem<InfoUser>();
            list.Add(new InfoUser("serh1", "srth1", "dyjdty1", 3, "erkgh1", "ieurg1", "keru1"));
            list.Add(new InfoUser("serh", "srth", "dyjdty", 3, "erkgh", "ieurg", "keru"));
            list.Add(new InfoUser("serh", "srth", "dyjdty", 3, "erkgh", "ieurg", "keru"));
            list.Add(new InfoUser("serh", "srth", "dyjdty", 3, "erkgh", "ieurg", "keru"));
            list.ForEach(Console.WriteLine);

            list.Remove(new InfoUser("serh1", "srth1", "dyjdty1", 3, "erkgh1", "ieurg1", "keru1"));
            list.ForEach(Console.WriteLine);

            list.Clear();
            list.ForEach(Console.WriteLine);
        }

    }
}

// using System;
// using System.Collections.Generic;
// using System.Linq;


// namespace NewProj
// {

//     class Program
//     {

//         // static void HidePassword(List<User> user){
//         //     foreach (var item in user)
//         //     {
//         //         for (var i = 0; i < item.Parole.Length; i++)
//         //         {
//         //             item.Parole[i]= item.Parole[i+item.Key];
//         //         }
//         //     }
//         // }

//         // static List<User> Compare(UserEqualityComparer_All CompareParole, List<User> user){
//         //    return user.Distinct(CompareParole);
//         // }
        
//         static void Main(string[] args)
//         {
//             List<User> users=new List<User>();

//             users.Add(new User("katerina", "123876", 18, true));
//             users.Add(new User("Danya2", "978534", 13, false));
//             users.Add(new User("Masshaa", "234576", 24, true));
//             users.Add(new User("user1234", "387687", 16, false));
//             users.Add(new User("katerina", "9864935", 18, true));
//             users.Add(new User("Natasha", "978534", 13, false));
//             users.Add(new User("Masshaa", "234576", 24, true));
//             users.Add(new User("petya23", "0998764", 16, false));
//             users.Add(new User("user435", "123876", 18, true));
//             users.Add(new User("Pashhsa", "022588", 13, false));
//             users.Add(new User("Kostya", "093344", 24, true));
//             users.Add(new User("kiygfi", "496854", 16, false));
//             users.Add(new User("katerina", "359754", 18, true));
//             users.Add(new User("Natasha", "978534", 13, false));
//             users.Add(new User("Vanyuaa", "395638", 24, true));
//             users.Add(new User("Cashaa", "498754", 16, false));

//             users.ForEach(Console.WriteLine);
            
//             // Console.WriteLine($"All is online:\t{users.All<User>((x) => x.IsOnline == true)}");
//             // Console.WriteLine($"All is adult:\t{users.All<User>((x) => x.Age >17)}");
//             // Console.WriteLine($"Average age users:\t{users.Average<User>((x) => x.Age)}");
//             // users.ForEach((x)=> x.Age++);
            
//         //    foreach(var i in users.Distinct(new UserEqualityComparer_Parole()))
//         //         System.Console.WriteLine(i);
//         //  var res= Compare(new UserEqualityComparer_All(), users);
//         //    foreach (var item in res)
//         //    {
//         //        System.Console.WriteLine(item);
//         //    }
//         }

//     }
// }