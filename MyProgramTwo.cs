using System; 
namespace MyProgram2 { 
  class Student {
    int StudentID; 
    string name; 
    string course; 
    int level; 
    static void Main (string[] args) {  
      Student LemonJelly = new Student(); 
      LemonJelly.StudentID = 1; 
      LemonJelly.name = "Lee Cox"; 
      LemonJelly.course = "ICT"; 
      LemonJelly.level = 3; 
      
      Student SevenClubs = new Student(); 
      SevenClubs.StudentID = 2; 
      SevenClubs.name = "Matt Bond"; 
      SevenClubs.course = "Business"; 
      SevenClubs.level = 3; 

      Console.WriteLine("Name: "+ LemonJelly.name); 
      Console.WriteLine("Course: "+LemonJelly.course); 
      Console.WriteLine("Level: "+LemonJelly.level);

    }
  }
}
