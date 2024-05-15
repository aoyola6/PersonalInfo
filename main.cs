using System;

class Program {
  public static void Main (string[] args) {
   string name =  "Chris Johnson";
    Console.WriteLine("Name: " + name); 
    
    DateOnly dateofBirth = new DateOnly(1987, 12, 1);
    Console.WriteLine("Date of Birth: " + dateofBirth);
    
    string workNumber = "000-222-0101";
    Console.WriteLine("Work Phone: " + workNumber);
    
    string cellNumber = "000-222-0189";
    Console.WriteLine("Cell Phone: " + cellNumber);
  }
} 