using System.Globalization;

Console.WriteLine("number 1: ");
string StrNumberOne =Console.ReadLine();

Console.WriteLine("number 2: ");
string StrNumberTwo = Console.ReadLine();

int IntNumberOne = int.Parse(StrNumberOne);
int IntNumberTwo = int.Parse(StrNumberTwo);

if (IntNumberOne > IntNumberTwo) Console.WriteLine("number 1 > number 2");
else if (IntNumberOne < IntNumberTwo) Console.WriteLine("number 2 > number 1");
     else Console.WriteLine("number 1 = number 2");