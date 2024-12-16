using System; 
namespace NumberWork5 { 
  class LuckyNumberGame { 
    static void Main(string[] args) { 
        Console.WriteLine ("Write your lucky number: ");
        int luckyNum = Convert.ToInt32(Console.ReadLine());
        
        switch (luckyNum) { 
            case 0: 
            case 1: 
            case 2:
            case 3: 
            case 4: 
            case 5: 
            case 6:
            case 7: 
            case 8: 
            case 9: 
            case 10:
            Console.WriteLine("You have no prize.");
            Console.WriteLine("Better Luck Next Time.");
            break; 
            case 11: 
            case 12:
            case 13: 
            case 14: 
            case 15: 
            case 16:
            case 17:
            case 18: 
            case 19: 
            case 20: 
            Console.WriteLine("You have a prize.");
            Console.WriteLine("Well Done"); 
            break; 
            default: 
            Console.WriteLine("Goodbye"); 
            break;
            
        }
    }
  }
}
