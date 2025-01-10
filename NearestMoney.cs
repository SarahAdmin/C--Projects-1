using System; 
namespace NumApp2 {
  class NearestMoney { 
    static decimal MyMoney(decimal num) { 
      return Math.Round(num);
      }
    static void (string[] args) {
      Console.WriteLine(MyMoney(9.99)); 
      Console.WriteLine(MyMoney(19.50));
    }
  }
}
