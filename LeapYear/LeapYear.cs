using System; 
class YearProject { 
  static bool LeapYear(int year) { 
    return year % 4 == 0; 
  }
  static void Main(string[] args) { 
    Console.WriteLine(LeapYear(1992)); 
    Console.WriteLine(LeapYear(1995)); 
    Console.WriteLine(LeapYear(1997)); 
    Console.WriteLine(LeapYear(2000)); 
    Console.WriteLine(LeapYear(2004)); 
    Console.WriteLine(LeapYear(2012)); 
    
  }
}
