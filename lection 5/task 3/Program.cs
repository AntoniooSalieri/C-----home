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
int Difference(int[] arr, int length){
    int min = arr[0];
    int max = arr[0];
    for(int i = 1; i < length; i++){
        if(max<arr[i]) max = arr[i];
        else if (min > arr[i]) min = arr[i];
    }
    int dif = max - min;
    return dif;
}


int arrayLength = 10;
int[] array = new int[arrayLength];
FillArray(array, arrayLength);
Printer(array, arrayLength);
Console.WriteLine();
Console.WriteLine(Difference(array, arrayLength));