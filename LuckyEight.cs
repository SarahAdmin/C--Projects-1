using System; 
namespace GameWork1 { 
  class LuckyEight { 
    static void Main(string[] args) { 
      Random randgame = New Random();
        int num = randgame.Next(1,9);
       switch(num) {
         case 1: 
           Console.WriteLine(num); 
           Console.WriteLine("Number One"); 
           break; 
         case 2: 
           Console.WriteLine(num); 
           Console.WriteLine("Number Two");
           break; 
         case 3: 
           Console.WriteLine(num); 
           Console.WriteLine("Number Three");
           break; 
         case 4: 
           Console.WriteLine(num); 
           Console.WriteLine("Number Four");
           break; 
         case 5: 
           Console.WriteLine(num); 
           Console.WriteLine("Number Five");
           break;
         case 6: 
           Console.WriteLine(num); 
           Console.WriteLine("Number Six");
           break;
         case 7:
           Console.WriteLine(num); 
           Console.WriteLine("Number Seven");
           break; 
         case 8:
           Console.WriteLine(num); 
           Console.WriteLine("Number Eight");
           Console.WriteLine("You are a Lucky One!"); 
           break; 
         default: 
           Console.WriteLine("Better Luck, Next Time");
           break;
       }        
       
    }
  }
}
