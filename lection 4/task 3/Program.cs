int IntInput(){
    return(Convert.ToInt32(Console.ReadLine()));
}
void FillArray(int[] InsertArray, int langth, int min, int max){
    for (int i = 0; i < langth; i++){
        InsertArray[i] = new Random().Next(min, max+1);
    }
}
void PritnArray(int[]InsertArray, int langth){
    for (int i = 0; i < langth; i++){
        Console.Write($"{InsertArray[i]}  ");
    }
}


Console.Write("Array langth: ");
int arrayLength = IntInput();
int[] array = new int[arrayLength];

Console.Write("Random min: ");
int RanMin = IntInput();
Console.Write("Random max: ");
int RanMax = IntInput();
Console.Write("Your array: ");

FillArray(array, arrayLength, RanMin, RanMax);
PritnArray(array, arrayLength);