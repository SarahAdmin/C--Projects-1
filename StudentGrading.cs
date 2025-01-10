using System; 
namespace StudentGrading { 
  class Student { 
    static void Main(string[] args) { 
      int currentModules = 4; 
      
      int LeeModule1 = 60; 
      int LeeModule2 = 75; 
      int LeeModule3 = 59; 
      int LeeModule4 = 68; 

      int MattModule1 = 80; 
      int MattModule2 = 90; 
      int MattModule3 = 75; 
      int MattModule4 = 100; 

      int JoModule1 = 56; 
      int JoModule2 = 60; 
      int JoModule3 = 90; 
      int JoModule4 = 100; 

      int ClairModule1 = 65; 
      int ClairModule2 = 70; 
      int ClairModule3 = 75; 
      int ClairModule4 = 80;

      int LeeModules = LeeModule1 + LeeModule2 + LeeModule3 + LeeModule4; 
      int MattModules = MattModule1 + MattModule2 + MattModule3 + MattModule4; 
      int JoModules = JoModule1 + JoModule2 + JoModule3 + JoModule4; 
      int ClairModules = ClairModule1+ ClairModule2 + ClairModule3 + ClairModule4; 

      /* Grades   
      Distinction = 70 - 100 
      Merit = 60 - 69 
      Pass = 50 - 59 
      Fail = < 40
      */

      Console.WriteLine("Lee Cox Grade: "+LeeModules / currentModules+" Merit"); 
      Console.WriteLine("Matt Bond Grade: "+MattModules / currentModules+" Distinction"); 
      Console.WriteLine("Jo Adams Grade: "+JoModules / currentModules+" Distinction"); 
      Console.WriteLine("Clair Parker Grade: "+ClairModules / currentModules+" Distinction");
    }
  }
}
  
