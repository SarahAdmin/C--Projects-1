using System; 
namespace MessageTwo { 
  class MyArrays { 
    static void Main (string[] args) { 
      try {
      string[] drinks = {"Milkshake","Cola","Coffee","Tea","Juice"};
      Console.WriteLine(drinks[11]); 
      }
      catch (Exception e) { 
        Console.WriteLine(e.Message)
        }
        
    }
  }
}
