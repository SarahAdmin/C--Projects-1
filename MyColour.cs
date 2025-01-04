using System; 
namespace myObject1 { 
  class Car { 
    string colour = 'Black'; 
    string make = 'Toyota'; 
    string model = 'Yaris';
    static void Main(string[] args) { 
      Car myDrive = new Car();
      Console.WriteLine(myDrive.make); 
      Console.WriteLine(myDrive.model); 
      Console.WriteLine(myDrive.colour);
    }
  }
}
