using System; 
namespace mySound; 
class Animal { 
  static void catSound() { 
    Console.WriteLine("Meow");
  }
}
class Car { 
  static void sound() { 
    Console.WriteLine("My Car goes Broom");
}
} 

public class myObjects { 
  static void Main(string[] args) { 
    Animal Cat = new Animal(); 
    Car myFiesta = new Car(); 

    Cat.catSound(); 
    myFiesta.sound(); 
    
  }
}
