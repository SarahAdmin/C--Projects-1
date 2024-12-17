using System;
namespace RaffleProject1 { 
  class RaffleTicketNumber { 
    static void Main(string[] args) { 
      Random randOne = new Random(); 
      int raffleNum = randOne.Next(1,250); 
      Console.WriteLine("Enter your Name: "); 
      string name = Console.ReadLine(); 

      if(raffleNum < 20) { 
      Console.WriteLine(raffleNum); 
      Console.WriteLine(name+" You pick your raffle number between 1 and 20"); 
      }
      else if (raffleNum >=20 && raffleNum <= 50) {
      Console.WriteLine(raffleNum); 
      Console.WriteLine(name+" You pick your raffle number between 21 and 50"); 
      }
      else if (raffleNum >=51 && raffleNum <=100) { 
       Console.WriteLine(raffleNum); 
      Console.WriteLine(name+" You pick your raffle number between 51 and 100"); 
      }
      else if (raffleNum >=100 && raffleNum <=200) {
      Console.WriteLine(raffleNum); 
      Console.WriteLine(name+" You pick your raffle number between 100 and 200"); 
      }
      else { 
      Console.WriteLine(raffleNum); 
      Console.WriteLine(name+" You pick your raffle number more than 200"); 
      }
    }
  }
}
