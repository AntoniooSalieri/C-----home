string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

number = number / 10;
number = number % 10;
Console.WriteLine(number);