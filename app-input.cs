using System 
class AppOne { 
   static void Main() { 
        Console.WriteLine("Enter your Name:");
        string name = Console.ReadLine(); 
        Console.WriteLine("Write your lucky number:");
        int luckynum = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Name: "+name); 
        Console.WriteLine("Lucky Number"+luckynum); 
   }
}
   
