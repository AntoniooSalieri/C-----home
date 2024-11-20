int num1,
    num2,
    num3;
string num1str,
        num2str,
        num3str;
int max;

Console.WriteLine("number 1: ");
num1str = Console.ReadLine();
Console.WriteLine("number 2: ");
num2str = Console.ReadLine();
Console.WriteLine("number 3: ");
num3str = Console.ReadLine();

num1 = int.Parse(num1str);
num2 = int.Parse(num2str);
num3 = int.Parse(num3str);

max = num1;
if (max < num2) max = num2;
if (max < num3) max = num3;

Console.WriteLine($"max = {max}");