using System;
namespace dicework1 { 
  class RollADice2 { 
    static void main(string[] args) { 
      Random RGame = new Random();
      int num = RGame.Next(1,7); 
      if(num == 1) { 
      Console.WriteLine(num);
      Console.WriteLine("You rolled Number One");
      }
      else if (num == 2) { 
      Console.WriteLine(num);
      Console.WriteLine("You rolled Number Two");
      }
     else if (num == 3) { 
     Console.WriteLine(num);
     Console.WriteLine("You rolled Number Three");
     }
     else if (num == 4) { 
     Console.WriteLine(num);
     Console.WriteLine("You rolled Number Four");
     }
     else if (num == 5) { 
     Console.WriteLine(num);
     Console.WriteLine("You rolled Number Five");
     }
     else if (num == 6) {
     Console.WriteLine(num);
     Console.WriteLine("You rolled Number Six");
     }
    else { 
    Console.WriteLine("No Number");
    }

      
    }
  }
}
