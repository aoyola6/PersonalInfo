using System;

class Program {
  public static void Main (string[] args) {
   string name =  "John Smith";
    Console.WriteLine("Name: " + name); 
    
    DateOnly dateofBirth = new DateOnly(1978, 8, 15);
    Console.WriteLine("Date of Birth: " + dateofBirth);
    
    string workNumber = "000-111-0101";
    Console.WriteLine("Work Phone: " + workNumber);
    
    string cellNumber = "000-111-0189";
    Console.WriteLine("Cell Phone: " + cellNumber);
  }
} 