int numberInt = new Random().Next(100, 1000);
string number = Convert.ToString(numberInt);
Console.WriteLine(numberInt);
Console.WriteLine($"{number[0]} {number[2]}");