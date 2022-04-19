
using System;

namespace MyApplication
{
  class Practice
  {
    static void Main(string[] args)
    {
      int x = 5;
      x++;
      Console.WriteLine(x);  
      int x = 5;
      int y = 3;
      Console.WriteLine(x + y); 
      Console.WriteLine(Math.Max(5, 10)); 
      Console.WriteLine(Math.Sqrt(64));
      Console.WriteLine(Math.Abs(-4.7));
      Console.WriteLine(Math.Round(9.99));
     
      string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      Console.WriteLine("The length of the txt string is: " + txt.Length);
      
      string secondtxt = "Hello World";
      Console.WriteLine(txt.ToUpper());   
      Console.WriteLine(txt.ToLower());
      
      string firstName = "John ";
      string lastName = "Doe";
      string name = firstName + lastName;
      Console.WriteLine(name);
      
      string myString = "Hello";
      Console.WriteLine(myString[0]);
     
      Console.WriteLine("Expect a C# version challenge end of today or early tommorow, for now random practice");
     }
  }
}
