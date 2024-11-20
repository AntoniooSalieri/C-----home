Console.WriteLine("enter your number");

string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

for (int i = 0; i < number; i++)
{
    Console.Write(i + " ");
}