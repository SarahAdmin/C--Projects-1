using System; 
namespace myAppilcationSeven { 
  class Application1 { 
    static void MyMethod(string firstName) { 
      Console.WriteLine(firstName + "Adams"); 
    }
    static void Main(string[] args) { 
      MyMethod("Lee"); 
      MyMethod("Matt"); 
      MyMethod("Jo"); 
      MyMethod("Anna"); 
    }
  }
}
