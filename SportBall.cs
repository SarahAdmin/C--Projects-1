using System; 
namespace myObject2 {
  class Ball { 
    string colour = 'Pink'; 
    double diameter = 1.5;
    static void Main(string[] args) { 
      Ball myNetball = new Ball(); 
      Console.WriteLine(myNetball.colour); 
      Console.WriteLine(myNetball.diameter);
    }
  }
}
