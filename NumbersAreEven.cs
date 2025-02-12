using System; 
namespace numberWork { 
  class NumbersAreEven { 
    static bool EvenNumbers(int num) { 
      return num % 2 == 0;
    }
    static void Main (string[] args) { 
      Console.WriteLine(EvenNumbers(2)); 
      Console.WriteLine(EvenNumbers(15)); 
      Console.WriteLine(EvenNumbers(20)); 
      Console.WriteLine(EvenNumbers(9)); 
      
    }
  }
