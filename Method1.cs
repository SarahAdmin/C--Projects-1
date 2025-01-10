using System; 
namespace MyFunWork { 
  class Method1 { 
      static void MyJellies(string flavour) { 
        Console.WriteLine(flavour+" Jelly");
    }
    static double MySquares(double num) { 
        return Math.Sqrt(num);
    }
    public static void Main(string[] args)
    {
        MyJellies("Strawberry"); 
        MyJellies("Lemon"); 
        MyJellies("Orange"); 
        MyJellies("Raspberry");
        Console.WriteLine(MySquares(64));
        Console.WriteLine(MySquares(256)); 
        Console.WriteLine(MySquares(4096));
    }
  }
}
