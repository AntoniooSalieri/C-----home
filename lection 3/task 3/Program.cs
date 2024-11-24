string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

for (int i = 1; i <= number; i++){
    Console.WriteLine(Math.Pow(i, 3));
}