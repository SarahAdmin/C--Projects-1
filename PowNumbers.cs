using System; 
namespace NumApp { 
  class PowNumbers { 
    static void MySquareNum(int num) { 
      return Math.Sqrt(num); 
      }
    static void Main(string[] args) { 
      MySquareNum(25); 
      MySquareNum(32); 
      MySquareNum(64); 
      MySquareNum(256); 
      
    }
  }
}
