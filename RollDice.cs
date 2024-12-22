using System; 
namespace Game1 {
  class RollADice { 
    static void Main(string[] args) {
      Random rgame = new Random(); 
      int dice = rgame.Next(1,7); 
      switch(dice) { 
        case 1: 
        Console.WriteLine(dice);
        Console.WriteLine("You rolled Number 1");
        break; 
        case 2: 
        Console.WriteLine(dice);
        Console.WriteLine("You rolled Number 2");
        break; 
        case 3: 
        Console.WriteLine(dice);
        Console.WriteLine("You rolled Number 3");
        break; 
        case 4: 
        Console.WriteLine(dice);
        Console.WriteLine("You rolled Number 4");
        break; 
        case 5: 
        Console.WriteLine(dice);
        Console.WriteLine("You rolled Number 5");
        break; 
        case 6: 
        Console.WriteLine(dice);
        Console.WriteLine("You rolled Number 6");
        break;
        default: 
        Console.WriteLine("No Number");
        break;
      }
    }
  }
}
