using System; 
namespace MyObjects { 
  class MyProgramOne { 
    static void Main(string[] args) { 
      Car Toyota = new Car(); 
      Toyota.model = "Yaris"; 
      Toyota.colour = "Black"; 
      Toyota.year = 2019; 
      Car Ford = new Car(); 
      Ford.model = "Fiesta"; 
      Ford.colour = "Blue"; 
      Ford.year = 2023; 

      Console.WriteLine("Model: "+Ford.model); 
      Console.WriteLine("Colour: "+Ford.colour);
      Console.WriteLine("Year: "+Ford.year);
    }
  }
}
