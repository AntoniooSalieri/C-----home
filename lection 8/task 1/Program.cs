int[,] testArray = new int[5, 5];
Random random = new Random();

void FillArrayRec (int[,] arr, int m = 0, int n = 0)
{
    if (m < arr.GetLength(0)){
        arr[n, m] = random.Next(0, 10);
        FillArrayRec(arr, m+1, n);
    }
    else{
        if (n + 1 < arr.GetLength(1)){
            FillArrayRec(arr, 0, n+1);
        }
    }
}

void SortOneLineRec (int[,] arr, int line, int position = 0)
{
    int max = arr[line, position];
    int positionMaxElement = position;
    for (int i = position; i < arr.GetLength(1); i++){
        if (max < arr[line, i]) {
            max = arr[line, i];
            positionMaxElement = i;
        }
    }
    arr[line, positionMaxElement] = arr[line, position];
    arr[line, position] = max;
    if (position < arr.GetLength(1)-1){
        SortOneLineRec(arr, line, position + 1);
    }
}

void ArraySorter (int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++){
        SortOneLineRec ( arr, i );
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

FillArrayRec(testArray);
Console.WriteLine();
PrintArray(testArray);
Console.WriteLine();
ArraySorter(testArray);
PrintArray(testArray);