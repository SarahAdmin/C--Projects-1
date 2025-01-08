using System; 
namespace MyApplicationEight { 
  class MyAppilcation2 { 
    static void MyJellies(string flavour) { 
      Console.WriteLine(flavour + " Jelly");
    }
    static void Main(string[] args) { 
      MyJellies("Lemon");
      MyJellies("Strawberry");
      MyJellies("Raspberry");
      MyJellies("Orange"); 
    }
  }
}
