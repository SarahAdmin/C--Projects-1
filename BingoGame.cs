using System; 
namespace GameWork1 { 
  class BingoGame { 
    static void Main(string[] args) { 
      Random randgame = new Random(); 
      int num = randgame.Next(1,100); 

      Console.WriteLine("Let's Play Bingo"); 
      Console.WriteLine(num);
    }
  }
}
