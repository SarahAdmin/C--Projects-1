using System; 
namespace NumApp { 
  class PowNumbers { 
    static double MySquareNum(int num) { 
      return Math.Sqrt(num); 
      }
    static void Main(string[] args) { 
      Console.WriteLine(MySquareNum(25)); 
      Console.WriteLine(MySquareNum(32)); 
      Console.WriteLine(MySquareNum(64)); 
      Console.WriteLine(MySquareNum(256)); 
      
    }
  }
}
