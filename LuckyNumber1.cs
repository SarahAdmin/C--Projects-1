using System; 
namespace LuckyNumber {
  class NumWork1 {
    static void Main(string[] args) { 
      Console.WriteLine("Enter your lucky number"); 
      int num = Convert.ToInt32(Console.ReadLine()); 

      if (num < 20) { 
        Console.WriteLine("Your Lucky Number: !"+num);
        Console.WriteLine("You have no prize :(, Better Luck Next Time!"); 
      }
      else if (num >= 20 && num <= 80) { 
        Console.WriteLine("Your Lucky Number: !"+num);
        Console.WriteLine("You got a Prize! :");
      }
      else { 
        Console.WriteLine("Goodbye");
      }
                          
    }
  }
}
