using System; 
namespace ArrayTwo {
  class Cafe {
    static void Main(string[] args) {
      string[] beverages = {'Coca Cola','Diet Coke','Lemonade','Fanta','Milkshake','Coffee','Tea','Orange Juice','Apple Juice'};
      Array.Sort(beverages);
      foreach { 
        (string i in beverages);
      }
      Console.WriteLine(i);
    }
  }
}
