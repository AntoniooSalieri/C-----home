Console.WriteLine("enter your number");

string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

for (int i = 0; i < number+1; i++)
{
    if (i % 2 == 0){
        Console.Write(i + " ");
    }
}