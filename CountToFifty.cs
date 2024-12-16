using System; 
namespace CountingNumbers1 { 
  class CountToFifty { 
    static void Main(string[] args) { 
      int i = 1; 
      do { 
        Console.WriteLine(i); 
        i++;
      }
      while (i < 51);
    }
  }
}
