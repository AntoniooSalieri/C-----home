int IntInput (){
    return Convert.ToInt32(Console.ReadLine());
}

int summ = 0;
int number = IntInput();
for (int i = number; i > 0; i = i / 10){
    summ = summ + i%10;
}

Console.WriteLine(summ);