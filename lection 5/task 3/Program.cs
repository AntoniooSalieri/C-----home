void FillArray(double[] arr, int length){
    for(int i = 0; i < length; i ++){
        arr[i] = new Random().Next(0, 10)+Math.Round(new Random().NextDouble(), 2);
    }
}
void Printer(double[] arr, int length){
    for(int i = 0; i < length; i++){
        Console.Write($" {arr[i]} ");
    }
}
double Difference(double[] arr, int length){
    double min = arr[0];
    double max = arr[0];
    for(int i = 1; i < length; i++){
        if(max<arr[i]) max = arr[i];
        else if (min > arr[i]) min = arr[i];
    }
    double dif = max - min;
    return dif;
}


int arrayLength = 10;
double[] array = new double[arrayLength];
FillArray(array, arrayLength);
Printer(array, arrayLength);
Console.WriteLine();
Console.WriteLine(Difference(array, arrayLength));