using System; 
namespace myProjectThree { 
  class TimeWork { 
    static void Main(string[] args) { 
      int time = 14; 
      if (time < 12) {
        Console.WriteLine("Good Morning");
      }
      else if (time < 18) { 
        Console.WriteLine("Good Afternoon");
      }
      else  {
        Console.WriteLine("Good Evening");
      }
                                                 
    }
  }
}
