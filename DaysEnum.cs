using System; 
class DaysofWeek { 
  enum Day { 
    Monday, 
    Tuesday, 
    Wednesday, 
    Thursday, 
    Friday, 
    Saturday, 
    Sunday
  }
  static void Main(string[] args) { 
    int num = (int) Day.Friday; 
    Console.WriteLine(num);
  }
}
