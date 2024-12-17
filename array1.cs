using System;
namespace MyArray { 
  class Menu1 { 
    static void Main(string[] args) { 
      string[] beverages = {"Cola","Diet Cola","Lemonade","Milkshake","Orange Juice","Apple Juice","Diet Lemonade","Fanta"};
      beverages[0] = "Coca-Cola"; 
      Console.WriteLine(beverages[3]);

      string[] fastFood = {"Big Mac","Cheeseburger","Fries","Hamburger","Hot-Dog","Veggie Burger","Chicken-Burger"};
      Console.WriteLine(fastFood[0]);
    }
  }
}
