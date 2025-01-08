using System; 
namespace MyApp5 { 
  class Car1 { 
    static void MyCars(string brand, string model) { 
      Console.WriteLine("My car is "+ brand + " and model is " + model);
    }
    static void Main(string[] args) { 
      MyCars("Toyota","Yaris"); 
      MyCars("Vauxhall","Corsa");
      MyCars("Volkswagen","T-Cross"); 
      MyCars("Ford","Fiesta"); 
             
    }
  }
}
