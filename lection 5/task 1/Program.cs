void FillArray(int[] arr, int arrayLength){
    for (int i = 0; i < arrayLength; i++){
        arr[i] = new Random().Next(100, 1000);
    }
}
int Counter(int[] arr, int arrayLength){
    int count = 0;
    for (int i = 0; i < arrayLength; i++){
        if (arr[i]%2 == 0){
            count++;
        }
    }
    return count;
}
void Printer(int[] arr, int arrayLength){
    for (int i = 0; i < arrayLength; i++){
        Console.Write($" {arr[i]} ");
    }
}

int length = 10;
int[] array = new int[length];

FillArray(array, length);
Printer(array, length);
Console.WriteLine();
Console.WriteLine(Counter(array, length));