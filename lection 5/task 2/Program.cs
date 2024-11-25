void FillArray(int[] arr, int length){
    for(int i = 0; i < length; i ++){
        arr[i] = new Random().Next(0, 10);
    }
}
void Printer(int[] arr, int length){
    for(int i = 0; i < length; i++){
        Console.Write($" {arr[i]} ");
    }
}

int Counter(int[] arr, int length){
    int counte = 0;
    for(int i = 0; i < length; i+=2){
        counte = counte + arr[i];
    }
    return counte;
}

int arrayLength = 10;
int[] array = new int[arrayLength];
FillArray(array, arrayLength);
Printer(array, arrayLength);
Console.WriteLine();
Console.WriteLine(Counter(array, arrayLength));