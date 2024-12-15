using System; 
namespace LuckNum2 { 
  class NumberWorkTwo { 
    static void Main(string[] args) { 
      Console.WriteLine("Enter your number: "); 
      int num = Convert.ToInt32(Console.ReadLine()); 

      switch (num) {
    case 20: 
      Console.WriteLine("You got a number "+num);
      break; 
    case 21: 
    case 22: 
    case 23: 
    case 24: 
    case 25: 
      Console.WriteLine("You got a number "+num); 
      Console.WriteLine("You have a prize!");
      break; 
      default: 
      Console.WriteLine("You got number more than 25 is "+num);
      break;
      }
      
    }
  }
}
