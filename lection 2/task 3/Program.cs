string numberStr = Console.ReadLine();
int numberInt = Convert.ToInt32(numberStr);
if (numberInt >= 100)
{
    Console.WriteLine(numberStr[2]);
}
else Console.WriteLine("error");