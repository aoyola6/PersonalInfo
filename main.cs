using System;

class Program {
  public static void Main (string[] args) {
   string name =  "Lucinda Potter";
    Console.WriteLine("Name: " + name); 
    
    DateOnly dateofBirth = new DateOnly(1992, 6, 24);
    Console.WriteLine("Date of Birth: " + dateofBirth);
    
    string workNumber = "000-000-0101";
    Console.WriteLine("Work Phone: " + workNumber);
    
    string cellNumber = "000-000-0189";
    Console.WriteLine("Cell Phone: " + cellNumber);
  }
} 