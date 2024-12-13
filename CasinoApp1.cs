using System; 
namespace CasinoApp { 
  class gameOne { 
    static void Main(string[] args) { 
      Console.ReadLine("Enter your name:  ");
      string name = Console.ReadLine(); 
      Console.WriteLine("Enter your lucky number: "); 
      int luckNum = Convert.ToInt32(Console.ReadLine()); 
      Console.WriteLine("Name: "+name); 
      Console.WriteLine("Lucky Number:"+luckNum); 
    }
  }
}
