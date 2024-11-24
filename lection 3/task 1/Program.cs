string input = Console.ReadLine();

int ConverterToInt(string numberText){
    int numberInt = Convert.ToInt32(numberText);
    Console.WriteLine(numberInt);               ///
    return numberInt;
}

int HowManyChars(int number){
    int count = 0;
    while (number > 0)
    {
        number = number / 10;
        count++;
    }
    Console.WriteLine(count);                    ///
    return count;
}

string OutputReversedNumber(int counter, string numberInput){
    string reversedNumber = "";
    for (int iaaa = counter-1; iaaa >= 0; iaaa--)
    {
        reversedNumber = reversedNumber + numberInput[iaaa];
        counter--;
    }
    return reversedNumber;
}

string numberReversed = OutputReversedNumber(HowManyChars(ConverterToInt(input)), input);
Console.WriteLine(numberReversed);

if (numberReversed == input) Console.WriteLine("+");
else Console.WriteLine("-");