string numberStr = Console.ReadLine();
int numberInt = Convert.ToInt32(numberStr);
int count = -1;
string numberRevers = "";
while (numberInt > 0)
{
    numberInt = numberInt / 10;
    count++;
}

while (count > -1)
{
    numberRevers = numberRevers + numberStr[count];
    count--;
}

Console.WriteLine(numberRevers);
if (numberRevers == numberStr) Console.WriteLine("+");
else Console.WriteLine("-");