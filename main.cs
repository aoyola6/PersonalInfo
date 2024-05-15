using System;

class Program {
  public static void Main (string[] args) {
   string name =  "Robert Hall";
    Console.WriteLine("Name: " + name); 
    
    DateOnly dateofBirth = new DateOnly(1949, 2, 27);
    Console.WriteLine("Date of Birth: " + dateofBirth);
    
    string workNumber = "000-444-0101";
    Console.WriteLine("Work Phone: " + workNumber);
    
    string cellNumber = "000-444-0189";
    Console.WriteLine("Cell Phone: " + cellNumber);
  }
} 